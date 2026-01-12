using System;

namespace Builder
{
    public class Garrison
    {
        public void TrainWarrior(WarriorBuilder builder)
        {
            builder.CreateWarrior();
            builder.EquipWeapon();
            builder.TrainCombat();
        }
    }
}