using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungAndDrag.GamePieces;

namespace DungAndDrag.GameData
{
    public class CharacterDescription
    {
        int strength;
        int dexterity;
        int constitution;
        int intelligence;
        int wisdom;
        int charisma;
        int acrobatics;
        int animalHandling;
        int arcana;
        int athleticis;
        int deception;
        int history;
        int insight;
        int intimidation;
        int investigation;
        int medicine;
        int nature;
        int percpetion;
        int performance;
        int persuation;
        int religion;
        int slieghtOfhand;
        int stealth;
        int survival;
        int level;
        int exp;
        int hitPoints;
        int speed;
        Image image;
            
        List<Skill> skillList;
        Spellbook spellbook;

        public Image Image { get => image; set => image = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Dexterity { get => dexterity; set => dexterity = value; }
        public int Constitution { get => constitution; set => constitution = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }
        public int Wisdom { get => wisdom; set => wisdom = value; }
        public int Charisma { get => charisma; set => charisma = value; }
        public int Acrobatics { get => acrobatics; set => acrobatics = value; }
        public int AnimalHandling { get => animalHandling; set => animalHandling = value; }
        public int Arcana { get => arcana; set => arcana = value; }
        public int Athleticis { get => athleticis; set => athleticis = value; }
        public int Deception { get => deception; set => deception = value; }
        public int History { get => history; set => history = value; }
        public int Insight { get => insight; set => insight = value; }
        public int Intimidation { get => intimidation; set => intimidation = value; }
        public int Investigation { get => investigation; set => investigation = value; }
        public int Medicine { get => medicine; set => medicine = value; }
        public int Nature { get => nature; set => nature = value; }
        public int Percpetion { get => percpetion; set => percpetion = value; }
        public int Performance { get => performance; set => performance = value; }
        public int Persuation { get => persuation; set => persuation = value; }
        public int Religion { get => religion; set => religion = value; }
        public int SlieghtOfhand { get => slieghtOfhand; set => slieghtOfhand = value; }
        public int Stealth { get => stealth; set => stealth = value; }
        public int Survival { get => survival; set => survival = value; }
        public int Level { get => level; set => level = value; }
        public int Exp { get => exp; set => exp = value; }
        public int HitPoints { get => hitPoints; set => hitPoints = value; }
        public int Speed { get => speed; set => speed = value; }

        internal List<Skill> SkillList { get => skillList; set => skillList = value; }
    }


}
