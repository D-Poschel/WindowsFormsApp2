using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.GamePieces;

namespace WindowsFormsApp2.GameData
{
    class ItemDescription
    {
        String itemName;
        double weaponDamage;
        WeaponType weaponType;
        WeaponEffect effect;

        public string ItemName { get => itemName; set => itemName = value; }
        public double WeaponDamage { get => weaponDamage; set => weaponDamage = value; }
        internal WeaponType WeaponType { get => weaponType; set => weaponType = value; }
        internal WeaponEffect Effect { get => effect; set => effect = value; }
    }
}
