using RPG.BLL.Items;

namespace RPG.BLL.Weapons
{
    public class ElectricShock: Weapon, IWeapon
    {
        public  const int DAMAGEEFFECT = 25;
        
        public ElectricShock(int id, string name) : base(id, name)
        {
            DamageEffectPoints = DAMAGEEFFECT;
        }
        
        
        public void Hit(int hits = 1)
        {
            
            
        }
    }
}