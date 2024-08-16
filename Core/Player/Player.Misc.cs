namespace Server
{
    public partial class Player : Humanoid
    {
        public void ChatMessage(ChatChannel type, string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                var messageId = GUID.Generate();

                switch (type)
                {
                    case ChatChannel.All:
                        var entities = new HashSet<Entity>(AreaOfInterest) { this };

                        foreach (var entity in entities)
                        {
                            Packet.Get(ServerPacketType.ChatMessage).Send(entity, new
                            {
                                SenderName = Name,
                                EntityId = MapIndex,
                                Channel = type,
                                MessageRef = messageId,
                                Message = message
                            });

                            Packet.Get(ServerPacketType.Say).Send(entity, new
                            {
                                Speaker = this,
                                Message = message,
                                Color = "255,255,255,255"
                            });
                        }
                        break;

                    case ChatChannel.Party:
                        if (Party != null)
                        {
                            foreach (var member in Party.Members.Values)
                            {
                                Packet.Get(ServerPacketType.ChatMessage).Send(member, new
                                {
                                    SenderName = Name,
                                    EntityId = MapIndex,
                                    Channel = type,
                                    MessageRef = messageId,
                                    Message = message
                                });
                            }
                        }
                        break;
                }
            }
        }

        public override void Revive()
        {
            base.Revive();
            Save();

            Task.Delay(500).ContinueWith(_ =>
            {
                TooltipSended.Clear();

                foreach (var slot in Inventory.Slots)
                {
                    var item = slot.Value;

                    Packet.Get(ServerPacketType.AddItemContainer).Send(this, new
                    {
                        Amount = item.Amount,
                        ContainerId = Inventory.ContainerId,
                        ItemName = item.Namespace,
                        ItemRef = item.Ref,
                        SlotId = slot.Key,
                        ItemRarity = item.Rarity,
                        GoldCost = item.GoldCost,
                        Weight = item.Weight
                    }, false);

                    if (item is Equipament || item is PowerScroll || item is PetItem || item is MountItem)
                    {
                        Packet.Get(ServerPacketType.Tooltip).Send(this, item.Ref, item.Serialize());
                    }
                }

                RefreshEquipamentsList();
                CalculateStats();
                CalculateStatics();
                SendTooltips();

                Packet.Get(ServerPacketType.UpdateSkillInfo).Send(this);
            });
        }

        public async Task InventoryChange()
        {
            var inventoryParsed = Inventory.SaveToModel();

            await Queue.EnqueueUpdateJobAsync(new JobData()
            {
                Table = "character",
                Id = CharacterId,
                Set = new
                {
                    inventory = inventoryParsed != null ? inventoryParsed : "{}"
                }
            });

            await Queue.EnqueueUpdateJobAsync(new JobData()
            {
                Table = "container",
                ContainerId = Inventory.ContainerId,
                CharacterId = CharacterId,
                Set = inventoryParsed
            });
        }

        public void Teleport(string mapName, string mapWaypoint)
        {
            Save();
            SaveToDatabase();

            var map = Maps.GetMap(mapName.Trim());

            if (map != null)
            {
                map.TeleportTo(this, mapWaypoint);
            }
            else
            {
                Packet.Get(ServerPacketType.SystemMessage)?.Send(Socket, $"Map '{mapName}' does not exist.");
            }
        }
    }
}
