using System.Collections.Generic;
using RPG.BLL.Items;
using RPG.BLL.Weapons;

namespace RPG.BLL.Geo
{
    public interface IScene
    {
       
        List<IWeapon> SetWeapons();
        List<Item> SetGold();
        List<Item> SetHearts();
     
        void SetLocations();
        void SetMap();
        void SetPlayerWeapons();
    }
}