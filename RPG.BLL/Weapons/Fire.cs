using RPG.BLL.Items;

namespace RPG.BLL.Weapons
{
    public class Fire : Weapon, IWeapon
    {
        const int DAMAGEEFFECT = 20;

        public Fire(int id, string name) : base(id, name)
        {
            DamageEffectPoints = DAMAGEEFFECT;
        }

        public void Hit(int hits = 1)
        {
        }
    }
}