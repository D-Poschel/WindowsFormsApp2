using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungAndDrag.GameData;

namespace DungAndDrag.GamePieces
{
    public class Item
    {
        public ItemDescription itemDescription;

        public Item()
        {
            this.itemDescription = new ItemDescription();
        }
    }
}
