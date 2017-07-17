using RPG.BLL.Geo;

namespace RPG.BLL.Creatures
{
    public class Creature
    {
        //All these info can be stored and persisted in NoSQL DBs (like MongoDB or DynamoDB) 
        public int Id { get; set; }
        public string Name { get; set; }
        //in case of player, how many hitpoints remaining to be killed by monster
        //in case of monster, how many hitpoints remainging to be killed by player
        //if it is zero => it is died
        //should be instantiated with full hits to die (e.g. 10, 20, 100)
        public int HitPointsToDie { get; set; }
        
        //if the monster died by player, it would be added to player account
        //it also keep track of current points of gold that player may use to purchase weapons 
        public int Gold { get; set; }
        
        //player should win the experience points if he killed the monster 
        //it also preserve how many experience points player should win if he successfully killed the monster
        //it also keep track of experience points for the player
        public int ExperiencePoints { get; set; }

        
        internal Creature()
        {
            
        }

        public Creature(int id, string name)
        {
            Id = id;
            Name = name;

        }
        public Creature(int id, string name, int hitPointsToDie, int gold, int experiencePoints)
        {
            Id = id;
            Name = name;
            HitPointsToDie = hitPointsToDie;
            Gold = gold;
            ExperiencePoints = experiencePoints;

        }


        //can be used for both player and monstr
        //player is attacking monster 
        //mnonster is attaching player
        public void Attack()
        {
            
        }
        
    }
}