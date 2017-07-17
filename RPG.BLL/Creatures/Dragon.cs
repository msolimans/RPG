using System;
using System.ComponentModel;
using RPG.BLL.Creatures.Behaviours;

namespace RPG.BLL.Creatures
{
    public class Dragon: Creature, IMonster
    {
        private const int CONST_HIT_POINTS = 20;
        private const int CONST_GOLD = 10;
        private const int CONST_EXPERIENCE = 2;
        
        //how much monster is strong (hit rate that monster is hitting the player)
        //e.g. 1 hit/sec - 2 hits/5 sec
        //Instead of HitRate we might use same kind of **Weapon** here also as it is owned by Monster (Weapon should have everything described there)
        //TO DO
        public int HitRate { get; set; }
        
        public Dragon() : base(new Random().Next(100), $"Dragon {new Random().Next(100)}")
        {
            SetFlyType(new CanFly());
          
            
        }
        
        
        public void Attack()
        {
            throw new System.NotImplementedException();
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