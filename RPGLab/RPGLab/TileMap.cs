using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGLab.RPGLab
{
    class TileMap
    {
        public static ImageList MapSprites;
        public static string[,] MainMap;
        public static int mapSize;
        public static string[] mapTileNames = {"Grass", "DirtRoad", "DirtRoad", "DirtRoad", "DirtRoad", "DirtRoad", "DirtRoad", "DirtRoad", "DirtRoad", "DirtRoad", "DirtRoad", "DirtRoad", "DungeonFortress", "DungeonTower", "MainCity", "DeadTree", "GreenTree", "TealTree", "MapleTree", "Autumn Tree", "RedoTree", "CobblestoneRoad", "CobblestoneRoad", "CobblestoneRoad", "CobblestoneRoad", "CobblestoneRoad", "CobblestoneRoad", "CobblestoneRoad", "CobblestoneRoad", "CobblestoneRoad", "CobblestoneRoad", "CobblestoneRoad", "DoubleCabin", "Cabin", "TripleCabin", "MowedGrass", "Water", "SandWaterSW", "SandWaterSE", "SandWaterNE", "SandWaterNW", "Sand", "GrassWaterNW", "GrassWaterSW", "GrassWaterSE", "GrassWaterNE", "MountainSnow", "Mountain", "Mountain", "Mountain", "CaveEntrance", "MountainSnow" };
        static string[] mapTileColliders = { "Water", "Mountain" };
        public static void OnLoad()
        {
            for (int i = 0; i < TileMap.MainMap.GetLength(1); i++)
            {
                for (int j = 0; j < TileMap.MainMap.GetLength(0); j++)
                {
                    if (MainMap[j, i] != ".")
                    {
                        string tileName = mapTileNames[Convert.ToInt32(MainMap[j, i])];
                        for (int k = 0; k < mapTileColliders.Length; k++)
                        {
                            if (tileName.Contains(mapTileColliders[k]))
                            {
                                new Collider(new Vector2(i, j), false);
                            }
                        }
                        Vector2 imagePos = new Vector2(i, j);
                        new Sprite2D(new Vector2(i, j), new Vector2(98, 66), (Image)Properties.Resources.ResourceManager.GetObject("_" + MainMap[j, i]), tileName);
                    }
                }
            }
        }
        public static void LoadMapSprites(ImageList Images)
        {
            MapSprites = Images;
        }
    }
}
