using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Utility
{
    class Dice
    {
        public static int roll(int sides)
        {
            Random r = new Random();
            return r.Next(0,sides);
        }
    }
}
