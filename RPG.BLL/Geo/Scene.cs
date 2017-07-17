using System.Collections.Generic;
using System.Net.NetworkInformation;
using RPG.BLL.Creatures;
using RPG.BLL.Items;
using RPG.BLL.Weapons;

namespace RPG.BLL.Geo
{
    //build a scene using eaither a template or builder patterns 
    //template will allow to build according to a template or boilerplate and choose at run time what to build (used to construct scene accordin to template)
    //we can also use here a builder pattern to build different parts of the scene 
    public class Scene : IScene
    {
          int Id;
        List<IWeapon> Weapons;
        List<Item> Gold;
        List<Item> Hearts;


        //start point location
        Location StartingLocation;

        //end point location
        Location EndLocation;


        //player choose map
        Map Map;

        //only one player
        private Player Player
        {
            get { return Player.GetInstane();}
        }

        private Scene(int id)
        {
            Id = id;
        }

        private static Scene instance;
        private const int DEFAULT_SCENE = 10;

        //no need to re-instantiate instance (if it is already the same and it is in memory)
        //however we need to reset the properties or data fields
        public static IScene GetInstance(int id = DEFAULT_SCENE)
        {
            //no instance instantiated
            //default scene = 10
            if(instance == null)
                instance = new Scene(id);
            
            //instance can be gotten from database (once instantiated and player wants to play again 
            else if(instance.Id != id)
                instance = new Scene(id);

            return instance;
        }


        //for most of set functions, we can use random generators to change how many numbers of monsters         
        public List<IWeapon> SetWeapons()
        {
            Weapons = new List<IWeapon>();
            Weapons.Add(new Sword(1, "Double Edge Sword"));
            Weapons.Add(new Fire(2, "Big Fire"));

            return Weapons;
        }
        

        public List<Item> SetGold()
        {
            Gold = new List<Item>();
            Gold.Add(new Gold(1, "Hidden Gold Barrel", 10));
            Gold.Add(new Gold(1, "Gold Hands", 50));
            Gold.Add(new Gold(1, "Ancient Gold", 2));

            return Gold;
        }

        public List<Item> SetHearts()
        {
            Hearts = new List<Item>();
            Hearts.Add(new Hearts(1, "Hearts Hidden Barrel", 20, 20));
            Hearts.Add(new Hearts(2, "Heavy Hearts Treasure", 20, 2));

            return Hearts;
        }


        public void SetLocations()
        {
            Location lakeView = new Location(1000, "Lake View");

            //all of these data might be instantiated randomly and according to experience level of player
            lakeView.Monsters.Add(MonsterFactory.CreateMonster());
            lakeView.Monsters.Add(MonsterFactory.CreateMonster());


            Location tower = new Location(1001, "Tower");
            tower.Monsters.Add(MonsterFactory.CreateMonster());


            Location postOffice = new Location(1002, "Post Office");
            Location bridge = new Location(1003, "Bridge");
            bridge.Monsters.Add(MonsterFactory.CreateMonster());

            //directions (surrounding places)
            bridge.SurroundingLocations.Add(0, postOffice);
            bridge.SurroundingLocations.Add(90, tower);
            tower.SurroundingLocations.Add(270, bridge);
            postOffice.SurroundingLocations.Add(180, bridge);
            postOffice.SurroundingLocations.Add(0, lakeView);
            lakeView.SurroundingLocations.Add(180, postOffice);


            StartingLocation = bridge;
            EndLocation = lakeView;
        }


        public void SetMap()
        {
            //map can be chosen from datbase if we have multiple maps
            Map = new Map(10, "My Map", "this is my map");

            this.Map.StartingLocation = StartingLocation;
            this.Map.EndLocation = EndLocation;
            //we can use the full constructor 
        }

        public void SetPlayerWeapons()
        {
            Player.Weapons = SetWeapons();
        }

       
    }
}