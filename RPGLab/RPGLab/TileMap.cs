using RPGLab.Networking;
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
        public static Vector2 CurrentWindowPosition = new Vector2(0, 0);
        public static void OnLoad()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    int x = i;
                    int y = j;
                    if (MainMap[y, x] != ".")
                    {
                        string tileName = mapTileNames[Convert.ToInt32(MainMap[y, x])];
                        for (int k = 0; k < mapTileColliders.Length; k++)
                        {
                            if (tileName.Contains(mapTileColliders[k]))
                            {
                                new Collider(new Vector2(x, y), false, "TileMap");
                            }
                        }
                        new MapTileSprites2D(new Vector2(x, y), new Vector2(98, 66), Convert.ToInt32(MainMap[y, x]), tileName);
                        AdventuresOnlineWindow.LoadingBar(x, 200, true);
                    }
                }
            }
            AdventuresOnlineWindow.LoadingBar(200, 200, false);
        }
        public static void LoadMapSprites(ImageList Images)
        {
            MapSprites = Images;
        }
    }
}
