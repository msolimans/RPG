namespace RPG.BLL.Creatures.Behaviours
{
    public interface IMonster
    {

        void SetHitPointsToDie(int hitPointsToDie);
        void SetGold(int gold);
        void SetExperienceLevel(int experienceLevel);


    }
}