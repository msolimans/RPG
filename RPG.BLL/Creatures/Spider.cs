using System;

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

        public Spider() : base(new Random().Next(100), $"Spider {new Random().Next(100)}")
        {
            
        }
        public Spider(int id, string name) : base(id, name)
        {
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