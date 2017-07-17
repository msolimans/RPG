using System;
using System.Xml.Xsl.Runtime;
using RPG.BLL.Creatures.Behaviours;

namespace RPG.BLL.Creatures
{
    
    //we might use also here Strategy pattern to add behaviors for each Creature (like running or flying)
    //Spider is flying - SavegeAnimal is moving and running - Dragon is flying
    //IMonster is used to force implementation of set methods here.
    public class Spider : Creature, IMonster
    {
 
        private const int CONST_HIT_POINTS = 50;
        private const int CONST_GOLD = 35;
        private const int CONST_EXPERIENCE = 3;

        //how much monster is strong (hit rate that monster is hitting the player)
        //e.g. 1 hit/sec - 2 hits/5 sec
        //Instead of HitRate we might use same kind of **Weapon** here also as it is owned by Monster (Weapon should have everything described there)
        //TO DO
        public int HitRate { get; set; }
        
        public Spider() : base(new Random().Next(100), $"Spider {new Random().Next(100)}")
        {
            //Specify the behaviour here of spider (can fly and run)
            SetFlyType(new CanFly());
            setRunType(new CanRun());
            
        }
        public Spider(int id, string name) : base(id, name)
        {
            SetFlyType(new CanFly());
            setRunType(new CanRun());
            
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