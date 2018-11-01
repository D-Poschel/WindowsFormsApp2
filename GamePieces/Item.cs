using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.GameData;

namespace WindowsFormsApp2.GamePieces
{
    class Item
    {
        private ItemDescription itemDescription;

        internal ItemDescription ItemDescription { get => itemDescription; set => itemDescription = value; }
    }
}
