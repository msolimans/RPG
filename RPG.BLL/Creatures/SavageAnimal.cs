using System;

namespace RPG.BLL.Creatures
{
    public class SavageAnimal : Creature, IMonster
    {
        private const int CONST_HIT_POINTS = 10;
        private const int CONST_GOLD = 10;
        private const int CONST_EXPERIENCE = 1;


        //how much monster is strong (hit rate that monster is hitting the player)
        //e.g. 1 hit/sec - 2 hits/5 sec
        //instead of HitRate we might use same kind of Weapon here also as it is owned by Monster (Weapon should have everything described there)
        public int HitRate { get; set; }


        //additions of multiple constructors are useless especially if they are not used however I kept for sharing my knowledge only
        public SavageAnimal(int id, string name, int hitPointsToDie, int gold, int experiencePoints) : base(id, name,
            hitPointsToDie, gold, experiencePoints)
        {
        }

        public SavageAnimal(int id, string name) : base(id, name)
        {
        }

        public SavageAnimal() : base(new Random().Next(100), $"Savage {new Random().Next(100)}")
        {
            
        }
       

        public void SetHitPointsToDie(int hitPointsToDie)
        {
            HitPointsToDie = CONST_HIT_POINTS;
        }

        public void SetGold(int gold)
        {
            Gold = CONST_GOLD;
        }

        public void SetExperienceLevel(int experienceLevel)
        {
            ExperiencePoints = CONST_EXPERIENCE;
        }
    }
}