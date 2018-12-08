using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungAndDrag.GameData;
using DungAndDrag.Utility;

namespace DungAndDrag.GamePieces
{
    public class Character
    {
        CharacterDescription description;
        public Inventory inventory;
        private string name;

        public Character()
        {
            
        }

        public Character(String name)
        {
            this.name = name;
            this.description = new CharacterDescription();
            description.HitPoints = 100;
            this.inventory = new Inventory();
            Item sword = new Item();
            sword.itemDescription.WeaponDamage = 5;
            this.inventory.activeWeapon = sword;
        }

        public int[] attackRoll(Character target)
        {
            int targetRoll = target.counterRoll(this);

            int myRoll = applyAttackBonuses(Dice.Instance.Roll(20));
            if(targetRoll < myRoll)
            {
                target.description.HitPoints -= (int)this.inventory.getActiveWeapon().itemDescription.WeaponDamage;
            }
            return new int[] { myRoll, targetRoll };
        }

        public String PrintStats()
        {
            String stats = "=======" + this.getName() + "========" + "\n";
            stats += "HEALTH:" + description.HitPoints + "\n";
            stats += "Attack:" + (int)this.inventory.getActiveWeapon().itemDescription.WeaponDamage + "\n";
            stats += "Acrobatics:" + description.Acrobatics + "\n";
            stats += "AnimalHandling:" + description.AnimalHandling + "\n";
            stats += "Arcana:" + description.Arcana + "\n";
            stats += "Athleticis:" + description.Athleticis + "\n";
            stats += "Charisma:" + description.Charisma + "\n";
            stats += "Constitution:" + description.Constitution + "\n";
            stats += "Deception:" + description.Deception + "\n";
            stats += "Dexterity:" + description.Dexterity + "\n";
            stats += "Exp:" + description.Exp + "\n";
            stats += "History:" + description.History + "\n";
            stats += "Insight:" + description.Insight + "\n";
            stats += "Intelligence:" + description.Intelligence + "\n";
            stats += "Intimidation:" + description.Intimidation + "\n";
            return stats;
        }

        private string getName()
        {
            return this.name;
        }

        public int counterRoll(Character target)
        {
            return applyDefenceBonuses(Dice.Instance.Roll(20));
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

        public CharacterDescription getDescription()
        {
            return this.description;
        }
    }
}
