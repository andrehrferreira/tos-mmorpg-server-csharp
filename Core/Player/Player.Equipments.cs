namespace Server
{
    public partial class Player : Humanoid
    {
        public override async Task Equip(EquipmentType type, string itemId, string itemRef, bool ring02 = false)
        {
            await base.Equip(type, itemId, itemRef, ring02);
            CalculateStats();
            Packet.Get(ServerPacketType.UpdateStats).Send(this);
            Packet.Get(ServerPacketType.PlayerStatics).Send(this);
            Save();
            await SaveToDatabase();
        }

        public override async Task Desequip(EquipmentType type, bool ring02 = false, bool broadcast = false, int slotId = -1)
        {
            await base.Desequip(type, ring02, broadcast, slotId);
            RefreshEquipamentsList();
            CalculateStatics();
            CalculateStats();
            Packet.Get(ServerPacketType.UpdateStats).Send(this);
            Packet.Get(ServerPacketType.PlayerStatics).Send(this);
            Save();
            await SaveToDatabase(); 
        }

        public async Task ReduceDurability(EquipmentType type)
        {
            switch (type)
            {
                case EquipmentType.Helmet:
                    await Items.ReduceDurability(Helmet.ItemRef, this);
                    var helmetItem = Items.GetItemByRef(Helmet.ItemRef);
                    Packet.Get(ServerPacketType.Tooltip).Send(this, Helmet.ItemRef, helmetItem.Serialize());
                    break;

                case EquipmentType.Chest:
                    await Items.ReduceDurability(Chest.ItemRef, this);
                    var chestItem = Items.GetItemByRef(Chest.ItemRef);
                    Packet.Get(ServerPacketType.Tooltip).Send(this, Chest.ItemRef, chestItem.Serialize());
                    break;

                case EquipmentType.Gloves:
                    await Items.ReduceDurability(Gloves.ItemRef, this);
                    var glovesItem = Items.GetItemByRef(Gloves.ItemRef);
                    Packet.Get(ServerPacketType.Tooltip).Send(this, Gloves.ItemRef, glovesItem.Serialize());
                    break;

                case EquipmentType.Pants:
                    await Items.ReduceDurability(Pants.ItemRef, this);
                    var pantsItem = Items.GetItemByRef(Pants.ItemRef);
                    Packet.Get(ServerPacketType.Tooltip).Send(this, Pants.ItemRef, pantsItem.Serialize());
                    break;

                case EquipmentType.Boots:
                    await Items.ReduceDurability(Boots.ItemRef, this);
                    var bootsItem = Items.GetItemByRef(Boots.ItemRef);
                    Packet.Get(ServerPacketType.Tooltip).Send(this, Boots.ItemRef, bootsItem.Serialize());
                    break;

                case EquipmentType.Offhand:
                    await Items.ReduceDurability(Offhand.ItemRef, this);
                    var offhandItem = Items.GetItemByRef(Offhand.ItemRef);
                    Packet.Get(ServerPacketType.Tooltip).Send(this, Offhand.ItemRef, offhandItem.Serialize());
                    break;

                case EquipmentType.Weapon:
                    await Items.ReduceDurability(Mainhand.ItemRef, this);
                    var mainhandItem = Items.GetItemByRef(Mainhand.ItemRef);
                    Packet.Get(ServerPacketType.Tooltip).Send(this, Mainhand.ItemRef, mainhandItem.Serialize());
                    break;

                case EquipmentType.Instrument:
                    await Items.ReduceDurability(Instrument.ItemRef, this);
                    var instrumentItem = Items.GetItemByRef(Instrument.ItemRef);
                    Packet.Get(ServerPacketType.Tooltip).Send(this, Instrument.ItemRef, instrumentItem.Serialize());
                    break;

                case EquipmentType.PickaxeTool:
                    await Items.ReduceDurability(Pickaxetool.ItemRef, this);
                    var pickaxetoolItem = Items.GetItemByRef(Pickaxetool.ItemRef);
                    Packet.Get(ServerPacketType.Tooltip).Send(this, Pickaxetool.ItemRef, pickaxetoolItem.Serialize());
                    break;

                case EquipmentType.AxeTool:
                    await Items.ReduceDurability(Axetool.ItemRef, this);
                    var axetoolItem = Items.GetItemByRef(Axetool.ItemRef);
                    Packet.Get(ServerPacketType.Tooltip).Send(this, Axetool.ItemRef, axetoolItem.Serialize());
                    break;

                case EquipmentType.ScytheTool:
                    await Items.ReduceDurability(Scythetool.ItemRef, this);
                    var scythetoolItem = Items.GetItemByRef(Scythetool.ItemRef);
                    Packet.Get(ServerPacketType.Tooltip).Send(this, Scythetool.ItemRef, scythetoolItem.Serialize());
                    break;
            }

            RefreshEquipamentsList();
            CalculateStatics();
        }


    }
}
