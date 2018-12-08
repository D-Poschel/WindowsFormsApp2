using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungAndDrag.Utility
{
    public class Dice
    {
        private static readonly Dice instance = new Dice();
        Random r;

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Dice()
        {
        }

        private Dice()
        {
            r = new Random();
        }

        public static Dice Instance
        {
            get
            {
                return instance;
            }
        }

        public int Roll(int sides)
        {
            return r.Next(1, sides + 1);
        }
    }
}
