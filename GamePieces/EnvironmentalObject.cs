using System;
using System.Drawing;

namespace DungAndDrag.GamePieces
{
    internal class EnvironmentalObject
    {
        InteractionEffect effect;
        public Image image;
        String RockImageLocation = "C:\\Users\\Daniel\\source\\repos\\WindowsFormsApp2\\WindowsFormsApp2\\Resources\\rock.png";

        public EnvironmentalObject(String objectType)
        {
            if (objectType.Equals("rock"))
            {
                image = Image.FromFile(RockImageLocation);
            }
            else
            {

            }
        }

        public string GetDescription()
        {
            return "This is a rock";
        }
    }
}