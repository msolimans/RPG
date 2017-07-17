namespace RPG.BLL.Creatures
{
    public interface IMonster
    {

        void SetHitPointsToDie(int hitPointsToDie);
        void SetGold(int gold);
        void SetExperienceLevel(int experienceLevel);


    }
}