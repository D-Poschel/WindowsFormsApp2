using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungAndDrag.GamePieces
{
    public class Inventory
    {
        int money;
        List<Item> itemList;
        public Item activeWeapon;

        public Item getActiveWeapon()
        {
            return activeWeapon;
        }
    }
}
