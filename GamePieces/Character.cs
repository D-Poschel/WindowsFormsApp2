using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.GameData;
using WindowsFormsApp2.Utility;

namespace WindowsFormsApp2.GamePieces
{
    class Character
    {
        CharacterDescription description = new CharacterDescription();
        Inventory inventory;

        public void attackRoll(Character target)
        {
            int targetRoll = target.counterRoll(this);
            int myRoll = applyAttackBonuses(Dice.roll(20));
            if(targetRoll < myRoll)
            {
                target.description.HitPoints -= (int)this.inventory.getActiveWeapon().ItemDescription.WeaponDamage;
            }
        }

        public int counterRoll(Character target)
        {
            return applyDefenceBonuses(Dice.roll(20));
        }

        private int applyAttackBonuses(int baseRoll)
        {
            //Todo: Modify roll based on skills and envirnmental factors
            return baseRoll;
        }

        private int applyDefenceBonuses(int baseRoll)
        {
            //Todo: Modify roll based on skills and envirnmental factors
            return baseRoll;
        }
    }
}
