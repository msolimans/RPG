using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using RPG.BLL.Geo;
using RPG.BLL.Items;
using RPG.BLL.Weapons;

namespace RPG.BLL.Creatures
{
    public class Player: Creature
    {
        //collected as an item (Heart object)
        //can be retreived and filled up from database
        public Hearts HeartPoints { get; set; }
       
        //we can have 2 weapons or more  (different types of weapons however each one will have different effect)
        //notice IWeapon is used here 
        public ICollection<IWeapon> Weapons { get; internal set; }

        public bool IsAlive => HitPointsToDie == 0;

        private static readonly object _lock = new object();
        private static Player instance;

        public static Player GetInstane()
        {
            //prevent race conditions in multi-threading 
            //however there is no need for it here as long as only one player is playing  (it is not multi-threading here)  
            lock (_lock)
            {
                if (null == instance)
                {
                    instance = new Player();
                }
                return instance;
            }
        }
        
        //Only factory should instantiate it (only one player)
        //private is to prevent creating instance of class
        private Player()
        {
        }

        
        //This allows player to move from current location by a specific degree
        public void MoveTo(int degree, Location currentLocation)
        {
            
        }
        

      
    }
}