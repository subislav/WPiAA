namespace Builder
{
    public abstract class WarriorBuilder
    {
        protected IWarrior _warrior;
        public void CreateWarrior()
        {
            _warrior = CreateInstance();
        }
        protected abstract IWarrior CreateInstance();
        public abstract void EquipWeapon();
        public abstract void TrainCombat();
        public IWarrior GetWarrior()
        {
            return _warrior;
        }
    }
}