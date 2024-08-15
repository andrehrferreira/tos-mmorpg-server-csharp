namespace Server
{
    public enum GatherableType
    {
        Tree,
        Stone,
        Bush,
        BigStone,
        IronSpot,
        CopperSpot,
        SilverSpot,
        GoldSpot,
        Coal,
        DarkSpot,
        MithrilSpot,
        HeavenlySpot
    }

    public class ItemResource
    {
        public Type Item { get; set; }
        public int Chance { get; set; }
        public int? Max { get; set; }

        public ItemResource(Type item, int chance, int? max = null)
        {
            Item = item;
            Chance = chance;
            Max = max;
        }
    }

    public class Gatherable
    {
        public IGatherable Settings { get; private set; }
        public Maps Map { get; private set; }
        public GatherableResource EntityRespawned { get; private set; }

        public Gatherable(IGatherable settings)
        {
            Settings = settings;
            Map = Maps.GetMap(settings.Map);

            if (settings.RespawnOnStart)
            {
                CreateEntity();
            }
        }

        public void Collected()
        {
            EntityRespawned = null;
            Settings.Timeout = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + (Settings.Timer * 1000);
        }

        public void Tick()
        {
            if (EntityRespawned == null && DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() > Settings.Timeout)
            {
                Settings.Timeout = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + (Settings.Timer * 1000);
                CreateEntity();
            }
        }

        private void CreateEntity()
        {
            EntityRespawned?.Destroy();

            var randomIndex = new Random().Next(Settings.Entities.Count);
            var gatheringName = Settings.Entities[randomIndex];
            var newResource = GatherableResource.Create(gatheringName, 0);

            if (newResource != null)
            {
                newResource.Settings = Settings;
                newResource.Map = Map;
                EntityRespawned = newResource;
                Map.AddFoliage(this, newResource);
            }
        }
    }

    public class GatherableResource
    {
        public IGatherable Settings { get; set; }
        public Maps Map { get; set; } = null;
        public string FoliageId { get; set; }
        public int Tick { get; set; } = RandomHelper.MinMaxInt(10, 20);
        public int InstanceId { get; set; }
        public Dictionary<int, List<ItemResource>> ResourcePerLevel { get; set; } = new Dictionary<int, List<ItemResource>>();
        public Type ResourceWithWrongEquipament { get; set; }
        public int IndexGreatLevel { get; set; } = 0;
        public SkillName Skill { get; set; } = SkillName.None;
        public EquipmentType EquipamentNeed { get; set; } = EquipmentType.None;
        public bool ConsumeAllTicks { get; set; } = false;
        public int MaxSkillGain { get; set; } = 5;

        public static Dictionary<GatherableType, Type> Resources { get; set; } = new Dictionary<GatherableType, Type>();

        public async Task Collect(Player player)
        {
            if (Tick <= 0)
            {
                Packet.Get(ServerPacketType.FinishCollect).Send(player, Settings.FoliageId);
                player.GatherableInteract = null;
            }

            if (Tick > 0)
            {
                Vector3 position = new Vector3(Settings.X, Settings.Y, Settings.Z);
                int skill = Math.Abs(player.GetSkillValue(Skill));
                int bonusCollect = 1;
                bool withoutEquipament = true;

                if (skill <= 1)
                    skill = 1;

                List<ItemResource> resources = new List<ItemResource> { 
                    new ItemResource(ResourceWithWrongEquipament, 100) 
                };

                switch (EquipamentNeed)
                {
                    case EquipmentType.AxeTool:
                        if (player.Axetool != null)
                        {
                            var axetoolItem = Items.GetItemByRef(player.Axetool.ItemRef);

                            if (axetoolItem != null && !axetoolItem.Flags.HasFlag(ItemStates.Broken))
                            {
                                resources = ResourcePerLevel.ContainsKey(skill)
                                    ? ResourcePerLevel[skill]
                                    : ResourcePerLevel[IndexGreatLevel];

                                withoutEquipament = false;
                                bonusCollect = Math.Max(player.BonusCollectsWood, 0);
                            }
                        }
                        break;

                    case EquipmentType.PickaxeTool:
                        if (player.Pickaxetool != null)
                        {
                            var pickaxetoolItem = Items.GetItemByRef(player.Pickaxetool.ItemRef);

                            if (pickaxetoolItem != null && !pickaxetoolItem.Flags.HasFlag(ItemStates.Broken))
                            {
                                resources = ResourcePerLevel.ContainsKey(skill)
                                    ? ResourcePerLevel[skill]
                                    : ResourcePerLevel[IndexGreatLevel];

                                withoutEquipament = false;
                                bonusCollect = Math.Max(player.BonusCollectsMineral, 0);
                            }
                        }
                        break;

                    case EquipmentType.ScytheTool:
                        if (player.Scythetool != null)
                        {
                            var scythetoolItem = Items.GetItemByRef(player.Scythetool.ItemRef);

                            if (scythetoolItem != null && !scythetoolItem.Flags.HasFlag(ItemStates.Broken))
                            {
                                resources = ResourcePerLevel.ContainsKey(skill)
                                    ? ResourcePerLevel[skill]
                                    : ResourcePerLevel[IndexGreatLevel];

                                withoutEquipament = false;
                                bonusCollect = Math.Max(player.BonusCollectsSkins, 0);
                            }
                        }
                        break;
                }

                if (resources.Count > 0 && Skill != SkillName.None && position.DistanceTo(player.Transform.Position) < 1000)
                {
                    int generateTicks = ConsumeAllTicks ? Tick : 1;

                    for (int i = 0; i < generateTicks; i++)
                    {
                        var itemBase = SelectRandomItem(resources);
                        int max = Math.Max(itemBase.Max ?? 1, skill);

                        if (bonusCollect < 0)
                            bonusCollect = 1;

                        int amount = (int)(RandomHelper.MinMaxInt(1, max) + Math.Max(Math.Round(max * (bonusCollect / 100.0)), 0));

                        if (amount < 1 || itemBase.Item == typeof(Gemstone))
                            amount = 1;

                        var baseItem = Activator.CreateInstance(itemBase.Item) as Item;
                        int hasStackableItem = player.Inventory.HasStackableItem(baseItem);
                        Tick--;

                        /*var itemRef = await player.Socket.Services.ItemsService.CreateItem(
                            player.Inventory.ContainerId,
                            player.CharacterId,
                            baseItem.Namespace,
                            amount,
                            "collect",
                            (hasStackableItem == -1)
                        );*/

                        Packet.Get(ServerPacketType.UpdateTick).Send(player, FoliageId, Tick);
                        Packet.Get(ServerPacketType.SystemMessage).Send(player, $"You received +{amount}x {baseItem.Name.Trim()}");
                        //player.Inventory.AddItem(itemRef, amount);
                    }

                    if (!withoutEquipament)
                    {
                        int playerSkill = player.GetSkillValue(Skill);

                        if (playerSkill < MaxSkillGain)
                            player.GainSkillExperience(Skill);

                        switch (EquipamentNeed)
                        {
                            case EquipmentType.AxeTool:
                                Items.ReduceDurability(player.Axetool.ItemRef, player);
                                break;
                            case EquipmentType.PickaxeTool:
                                Items.ReduceDurability(player.Pickaxetool.ItemRef, player);
                                break;
                            case EquipmentType.ScytheTool:
                                Items.ReduceDurability(player.Scythetool.ItemRef, player);
                                break;
                        }
                    }

                    player.Save();

                    if (Tick <= 0)
                    {
                        Packet.Get(ServerPacketType.FinishCollect).Send(player, Settings.FoliageId);

                        foreach (var entity in Map.EntitiesMapIndex.Values)
                        {
                            if (entity is Player)
                                Packet.Get(ServerPacketType.FinishCollect).Send((Player)entity, Settings.FoliageId);
                        }
                    }
                }
            }
            else
            {
                Packet.Get(ServerPacketType.FinishCollect).Send(player, Settings.FoliageId);
                Packet.Get(ServerPacketType.SystemMessage).Send(player, "The resource has been exhausted and can no longer be collected");

                foreach (var entity in Map.EntitiesMapIndex.Values)
                {
                    if (entity is Player)
                        Packet.Get(ServerPacketType.FinishCollect).Send((Player)entity, Settings.FoliageId);
                }
            }
        }

        public static void Add(GatherableType type, Type cls)
        {
            Resources[type] = cls;
        }

        public static GatherableResource Create(GatherableType type, int instanceId)
        {
            if (Resources.ContainsKey(type))
            {
                var resource = Activator.CreateInstance(Resources[type]) as GatherableResource;
                resource.InstanceId = instanceId;
                return resource;
            }

            return null;
        }

        protected (Type Item, int? Max) SelectRandomItem(List<ItemResource> items)
        {
            int totalChances = items.Sum(i => i.Chance);
            double random = new Random().NextDouble() * totalChances;

            foreach (var item in items)
            {
                random -= item.Chance;

                if (random <= 0)
                    return (item.Item, item.Max);
            }

            var lastItem = items.Last();
            return (lastItem.Item, lastItem.Max);
        }

        public void SetEntityId(string foliageId)
        {
            FoliageId = foliageId;
        }

        public void Destroy()
        {
            Map.RemoveFoliage(FoliageId);
        }
    }
}
