using System;

namespace Factory
{
    public class Garrison
    {
        public Warrior TrainWarrior(string unitType)
        {
            switch (unitType.ToLower())
            {
                case "infantry":
                    return new Infantry();
                case "archer":
                    return new Archer();
                case "cavalry":
                    return new Cavalry();
                default:
                    throw new Exception("Nie ma takiego wojownika!");
            }
        }
    }
}