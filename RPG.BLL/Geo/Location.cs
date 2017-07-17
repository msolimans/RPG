using System;
using System.Collections.Generic;
using RPG.BLL.Creatures;

namespace RPG.BLL.Geo
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        //each location has 1 or more monsters inside 
        public List<Creature> Monsters { get; set; }

        //degree or direction with surrounding location 
        //e.g. 45 degree and "LA"
        //e.g. 0 degree and "LB"
        //e.g. 90 degree and "LC"
        //e.g. 250 degree and "LD"
        public Dictionary<int, Location> SurroundingLocations { get; set; }

        public Location(int id, string name)
        {
            Id = id;
            Name = name;
            Monsters = new List<Creature>(); 
            SurroundingLocations = new Dictionary<int, Location>();
        }
        
        public Location(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
            Monsters = new List<Creature>();
            SurroundingLocations = new Dictionary<int, Location>();
        }
    }
}