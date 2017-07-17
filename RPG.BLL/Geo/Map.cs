using System;
using System.Collections.Generic;

namespace RPG.BLL.Geo
{
    public class Map
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String Description { get; set; }
       
        //map has many locations
        public Location StartingLocation { get; set; }
        public Location EndLocation { get; set; }

        public Map(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
            
        }
        
        public Map(int id, string name, string description, Location startLocation, Location endLocation)
        {
            Id = id;
            Name = name;
            Description = description;
            StartingLocation = startLocation;
            EndLocation = endLocation;
        }
        
    }
}