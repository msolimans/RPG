using System;
using RPG.BLL.Items;

namespace RPG.BLL.Items
{
    public class Weapon: Item
    {
        
       
        public int DamageEffectPoints  { get; set; }

        public Weapon(int id, string name): base(id, name)
        {
            
        }
        
        
    }
}