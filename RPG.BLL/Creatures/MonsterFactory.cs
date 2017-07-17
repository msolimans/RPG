using System;

namespace RPG.BLL.Creatures
{
    //Factory pattern here
    public class MonsterFactory
    {
        private const int CreatureTypesCount = 3;

        public enum CreatureTypes
        {
            Dragon = 1,
            Spider,
            SavageAnimal
        };

        //random generation of monsters here
        public static Creature CreateMonster()
        {
            var type = (CreatureTypes) Enum.Parse(typeof(CreatureTypes),
                new Random().Next(CreatureTypesCount).ToString());

            switch (type)
            {
                case CreatureTypes.Dragon:
                    return new Dragon();
                case CreatureTypes.SavageAnimal:
                    return new SavageAnimal();

                case CreatureTypes.Spider:
                default:
                    return new Spider();
            }
        }
    }
}