using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungAndDrag.GamePieces
{
    class Map
    {
        Tile[,] tiles;
        String mapName;
        public Map(String mapName, int TileSize, int Length, int Width)
        {
            this.mapName = mapName;
            tiles = new Tile[Length, Width];

            int i, j;

            for (i = 0; i < Length; i++)
            {
                for (j = 0; j < Width; j++)
                {
                    this.tiles[i, j] = new Tile();
                    this.tiles[i, j].BackColor = System.Drawing.SystemColors.ActiveCaption;
                    this.tiles[i, j].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    this.tiles[i, j].Location = new System.Drawing.Point(50 + i * 40, 50 + j * 40);
                    this.tiles[i, j].Name = mapName;
                    this.tiles[i, j].Size = new System.Drawing.Size(TileSize, TileSize);
                    this.tiles[i, j].TabIndex = 2;
                    this.tiles[i, j].TabStop = false;
                    
                }
            }

            this.tiles[3, 5].environmentalObject = new EnvironmentalObject("rock");
            this.tiles[6, 7].environmentalObject = new EnvironmentalObject("rock");
            this.tiles[1, 3].environmentalObject = new EnvironmentalObject("rock");
        }

        public void RefreshMap()
        {
            for (int i = 0; i < Math.Sqrt(tiles.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(tiles.Length); j++)
                {
                    if(tiles[i,j].environmentalObject != null)
                    {
                        this.tiles[i, j].Image = this.tiles[i, j].environmentalObject.image;
                    }
                    if (tiles[i,j].character != null)
                    {
                        
                    }
                    
                }
            }
        }

        public Tile[,] getTiles()
        {
            return tiles;
        }

        public String getMapName()
        {
            return mapName;
        }
    }
}
