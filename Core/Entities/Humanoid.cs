
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
        public void AddToInventory(string itemRef, int amount, int slotId = -1)
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
                    Inventory.ClearSlot(itemSlot.SlotId);
                    EquipamentRef equipamentRef = new EquipamentRef { ItemName = itemSlot.Item.Namespace, ItemRef = itemSlot.Item.Ref }; 
                    await Desequip(equipament.EquipmentType, ring02, false);

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

        public int GetEquipamentsResistence(ResistanceType resistenceType)
        {
            int total = 0;

            if (Equipaments != null && Equipaments.Count > 0)
            {
                foreach (var equipament in Equipaments)
                {
                    if (equipament != null && !equipament.Flags.HasFlag(ItemStates.Broken))
                    {
                        switch (resistenceType)
                        {
                            case ResistanceType.Physical: total += equipament.Armor; break;
                            case ResistanceType.Fire: total += equipament.FireResistence; break;
                            case ResistanceType.Cold: total += equipament.ColdResistence; break;
                            case ResistanceType.Poison: total += equipament.PoisonResistence; break;
                            case ResistanceType.Energy: total += equipament.EnergyResistence; break;
                            case ResistanceType.Light: total += equipament.LightResistence; break;
                            case ResistanceType.Dark: total += equipament.DarkResistence; break;
                        }
                    }
                }
            }

            return total;
        }

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

        //Damage
        public override void CheckHitAutoAttack(ICheckHitAutoAttack data)
        {
            try
            {
                var actor = Map.FindEntityById(data.ActorId);

                if (actor == null || !ValidateHit(data, actor))
                    throw new Exception("Invalid data hit");

                var bonusDamage = GetWeaponBaseDamage();
                actor.TakeDamage(this, Dices.D1D4, DamageType.Physic, bonusDamage);
                // this.GainSkillExperienceByWeapon(this.GetWeaponType());
            }
            catch (Exception ex){}
        }

        public override int GetWeaponBaseDamage()
        {
            var weapon = Mainhand != null ? Items.GetItemByRef(Mainhand.ItemRef) as Weapon : null;
            var baseDamage = weapon != null ? weapon.Damage : Dices.D1D4;
            var bonusDamage = 0;

            if (weapon != null && weapon.Flags.HasFlag(ItemStates.Broken))
                baseDamage = Dices.D1D4;

            if (weapon != null)
                bonusDamage = weapon.BonusDamage;

            var bonusBySkill = GetSkillBonusByWeaponType(GetWeaponType());
            return RollDice(baseDamage) + bonusBySkill + bonusDamage;
        }

        public Dices GetWeaponDiceDamage()
        {
            var weapon = Mainhand != null ? Items.GetItemByRef(Mainhand.ItemRef) as Weapon : null;

            if (weapon != null && weapon.Flags.HasFlag(ItemStates.Broken))
                weapon = null;

            return weapon != null ? weapon.Damage : Dices.D1D4;
        }

        public int GetWeaponSpeed()
        {
            var weapon = Mainhand != null ? Items.GetItemByRef(Mainhand.ItemRef) as Weapon : null;
            return weapon != null ? weapon.AttackSpeed : 0;
        }

        public override WeaponType GetWeaponType()
        {
            var weapon = Mainhand != null ? Items.GetItemByRef(Mainhand.ItemRef) as Weapon : null;
            return weapon != null ? weapon.WeaponType : WeaponType.None;
        }
    }
}
