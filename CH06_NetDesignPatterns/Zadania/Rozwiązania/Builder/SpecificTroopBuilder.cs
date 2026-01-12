namespace Builder
{
    public class InfantryBuilder : WarriorBuilder
    {
        protected override IWarrior CreateInstance() { return new Infantry(); }
        public override void EquipWeapon()
        {
            _warrior.Weapon = "Miecz i Tarcza";
        }
        public override void TrainCombat()
        {
            _warrior.Action = "Trening walki wręcz";
        }
    }
    public class ArcherBuilder : WarriorBuilder
    {
        protected override IWarrior CreateInstance() { return new Archer(); }
        public override void EquipWeapon()
        {
            _warrior.Weapon = "Łuk";
        }
        public override void TrainCombat()
        {
            _warrior.Action = "Trening celności";
        }
    }
    public class CavalryBuilder : WarriorBuilder
    {
        protected override IWarrior CreateInstance() { return new Cavalry(); }
        public override void EquipWeapon()
        {
            _warrior.Weapon = "Lanca";
        }
        public override void TrainCombat()
        {
            _warrior.Action = "Trening jazdy konnej";
        }
    }
}