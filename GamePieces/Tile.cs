using System;
using System.Windows.Forms;

namespace DungAndDrag.GamePieces
{
    internal class Tile: PictureBox
    {
        string terrainType;
        public Character character;
        public EnvironmentalObject environmentalObject;

        public Tile()
        {
            this.MouseClick += new MouseEventHandler((o, a) => handleSelfClick());
        }

        private void handleSelfClick()
        {
            if(character != null)
            {
                ((Form1)this.FindForm()).InfoBox = character.PrintStats();
            }
            if(environmentalObject!=null)
            {
                ((Form1)this.FindForm()).InfoBox = environmentalObject.GetDescription();
            }
        }
    }
}