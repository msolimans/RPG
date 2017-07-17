using System.Collections.Generic;

namespace RPG.BLL.Items
{
    //collection of hearts and golds
    public class Treasure
    {
        
        //treasure might have hearts and golds 
        //each might have different amount of items 
        //item is the base class for both 
        public Dictionary<int, Item> Items { get; }

        public Treasure()
        {
            Items = new Dictionary<int, Item>();
        }

        public void Add(int quantity, Item item)
        {
            Items.Add(quantity, item);
        }
        
        
    }
}