using RPG.BLL.Items;

namespace RPG.BLL.Weapons
{
    public class Sword: Weapon, IWeapon
    {
           const int DAMAGEEFFECT = 10;
        
        public Sword(int id, string name) : base(id, name)
        {
            DamageEffectPoints = DAMAGEEFFECT;
        }
        
        //each weapon will affect differently than others
        //we should pass 
        public void Hit(int hits = 1)
        {
            
        }
        
        
    }
}