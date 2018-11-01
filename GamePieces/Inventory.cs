using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.GamePieces
{
    class Inventory
    {
        int money;
        List<Item> itemList;
        Item activeWeapon;

        public Item getActiveWeapon()
        {
            return activeWeapon;
        }
    }
}
