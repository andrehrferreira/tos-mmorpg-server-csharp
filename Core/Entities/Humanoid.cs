
namespace Server
{
    public class Humanoid : Entity
    {
        public string Visual { get; set; }

        // Equipamentos
        public IEquipament Helmet { get; set; }
        public IEquipament Chest { get; set; }
        public IEquipament Gloves { get; set; }
        public IEquipament Pants { get; set; }
        public IEquipament Boots { get; set; }
        public IEquipament Robe { get; set; }
        public IEquipament Cloak { get; set; }

        public IEquipament Ring01 { get; set; }
        public IEquipament Ring02 { get; set; }
        public IEquipament Necklance { get; set; }
        public IEquipament Instrument { get; set; }

        public IEquipament Mainhand { get; set; }
        public IEquipament Offhand { get; set; }

        public IEquipament Pet { get; set; }
        public Pet PetInstance { get; set; }
        public IEquipament Mount { get; set; }

        public IEquipament Pickaxetool { get; set; }
        public IEquipament Axetool { get; set; }
        public IEquipament Scythetool { get; set; }

        public List<Equipament> Equipaments { get; private set; } = new List<Equipament>();

        public void Init()
        {
            Kind = EntitiesKind.Monster;
            States = new StateFlags(EntityStates.None);
            Team = new Team(TeamKind.Monsters, this);
            TeamOwner = this;

            RefreshEquipamentsList();
        }

        public override void Destroy()
        {
            base.Destroy();

            if (Pet?.ItemRef != null)
                (Items.GetItemByRef(Pet.ItemRef) as PetItem)?.OnDesequip(this);

            if (Mount?.ItemRef != null)
                (Items.GetItemByRef(Mount.ItemRef) as MountItem)?.OnDesequip(this);
        }

        // Inventory / Equipamentos
        /*public void AddToInventory(string itemRef, int amount, int slotId = -1)
        {
            if (!string.IsNullOrEmpty(itemRef) && Inventory != null)
                Inventory.AddItem(itemRef, amount, slotId);
        }

        public async Task Equip(EquipmentType type, string itemId, string itemRef, bool ring02 = false)
        {
            if (Inventory.HasItem(itemRef))
            {
                var itemSlot = Inventory.GetItemSlot(itemRef);
                var equipament = itemSlot.Item as Equipament;

                if (equipament != null)
                {
                    await Inventory.ClearSlot(itemSlot.SlotId);
                    var equipamentRef = new { ItemName = itemSlot.Item.Namespace, ItemRef = itemSlot.Item.Ref };
                    Desequip(equipament.EquipmentType, ring02, false);

                    switch (equipament.EquipmentType)
                    {
                        case EquipmentType.Helmet: Helmet = equipamentRef; break;
                        case EquipmentType.Chest: Chest = equipamentRef; break;
                        case EquipmentType.Gloves: Gloves = equipamentRef; break;
                        case EquipmentType.Pants: Pants = equipamentRef; break;
                        case EquipmentType.Boots: Boots = equipamentRef; break;
                        case EquipmentType.Cloak: Cloak = equipamentRef; break;
                        case EquipmentType.Robe: Robe = equipamentRef; break;
                        case EquipmentType.Necklance: Necklance = equipamentRef; break;
                        case EquipmentType.Ring:
                            if (ring02)
                                Ring02 = equipamentRef;
                            else
                                Ring01 = equipamentRef;
                            break;
                        case EquipmentType.Offhand: Offhand = equipamentRef; break;
                        case EquipmentType.Weapon: Mainhand = equipamentRef; break;
                        case EquipmentType.Instrument: Instrument = equipamentRef; break;
                        case EquipmentType.Pet:
                            Pet = equipamentRef;
                            (equipament as PetItem)?.OnEquip(this);
                            break;
                        case EquipmentType.Mount:
                            Mount = equipamentRef;
                            (equipament as MountItem)?.OnEquip(this);
                            break;
                        case EquipmentType.PickaxeTool: Pickaxetool = equipamentRef; break;
                        case EquipmentType.AxeTool: Axetool = equipamentRef; break;
                        case EquipmentType.ScytheTool: Scythetool = equipamentRef; break;
                    }

                    if (equipament.EquipmentType == EquipmentType.Weapon)
                    {
                        var weapon = equipament as Weapon;

                        if (weapon != null && IsTwoHandedWeapon(weapon.WeaponType))                        
                            await Desequip(EquipmentType.Offhand, false, false);                        
                    }

                    if (equipament.EquipmentType == EquipmentType.Offhand && Mainhand != null)
                    {
                        var weapon = Items.GetItemByRef(Mainhand.ItemRef) as Weapon;

                        if (weapon != null && IsTwoHandedWeapon(weapon.WeaponType))                        
                            await Desequip(EquipmentType.Weapon, false, false);
                    }

                    Broadcast(Packet.Get(ServerPacketType.Equip), new { type, itemId });

                    RefreshEquipamentsList();
                    CalculateStatics();
                    Save();
                }
            }
        }
        */
        private bool IsTwoHandedWeapon(WeaponType weaponType)
        {
            return weaponType == WeaponType.TwoHandedAxe ||
                   weaponType == WeaponType.TwoHandedHammer ||
                   weaponType == WeaponType.TwoHandedSword ||
                   weaponType == WeaponType.Crossbow ||
                   weaponType == WeaponType.Bow ||
                   weaponType == WeaponType.Staff ||
                   weaponType == WeaponType.Spear;
        }

        public async Task Desequip(EquipmentType type, bool ring02 = false, bool broadcast = false, int slotId = -1)
        {
            switch (type)
            {
                // Implementação dos cases de desequipamento semelhante ao do TypeScript
            }
        }

        public void RefreshEquipamentsList()
        {
            Equipaments.Clear();

            AddEquipamentToList(Helmet);
            AddEquipamentToList(Chest);
            AddEquipamentToList(Gloves);
            AddEquipamentToList(Pants);
            AddEquipamentToList(Boots);
            AddEquipamentToList(Ring01);
            AddEquipamentToList(Ring02);
            AddEquipamentToList(Necklance);
            AddEquipamentToList(Cloak);
            AddEquipamentToList(Robe);
            AddEquipamentToList(Offhand);
            AddEquipamentToList(Mainhand);
            AddEquipamentToList(Instrument);
            AddEquipamentToList(Pet);
            AddEquipamentToList(Mount);
            AddEquipamentToList(Pickaxetool);
            AddEquipamentToList(Axetool);
            AddEquipamentToList(Scythetool);

            CalculateStatics();
            RefreshEquipamentsHeavy();
        }

        private void AddEquipamentToList(IEquipament equipament)
        {
            if (equipament != null)
            {
                var item = Items.GetItemByRef(equipament.ItemRef) as Equipament;
                if (item != null)
                    Equipaments.Add(item);
            }
        }

        public int GetEquipamentsAttr(AttributeType type)
        {
            int total = 0;

            if (Equipaments != null && Equipaments.Count > 0)
            {
                foreach (var equipament in Equipaments)
                {
                    if (equipament.Attrs.ContainsKey(type) && !equipament.Flags.HasFlag(ItemStates.Broken))
                        total += equipament.Attrs[type];
                }
            }

            return total;
        }

        /*public int GetEquipamentsResistence(ResistenceType resistenceType)
        {
            int total = 0;

            if (Equipaments != null && Equipaments.Count > 0)
            {
                foreach (var equipament in Equipaments)
                {
                    if (equipament != null && !equipament.Flags.HasFlag(ItemStates.Broken))
                    {
                        total += equipament.GetResistence(resistenceType);
                    }
                }
            }

            return total;
        }*/

        public void RefreshEquipamentsHeavy()
        {
            bool hasEquipmentMediumPart = false;
            bool hasEquipmentHeavyPart = false;

            if (Equipaments != null && Equipaments.Count > 0)
            {
                foreach (var equipament in Equipaments)
                {
                    if (equipament.EquipmentWeight == EquipmentWeight.Medium)
                        hasEquipmentMediumPart = true;
                    else if (equipament.EquipmentWeight == EquipmentWeight.Heavy)
                        hasEquipmentHeavyPart = true;
                }
            }

            HasMediumEquipamentPart = hasEquipmentMediumPart;
            HasHeavyEquipamentPart = hasEquipmentHeavyPart;
        }
    }
}
