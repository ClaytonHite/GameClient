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
        public bool UpdatePlayerLocation;
        public static Vector2 CurrentWindowPosition = new Vector2(0, 0);
        public static void OnLoad()
        {
        }
        public static void UpdateVisibleSprites()
        {
            if (GameManager.players.ContainsKey(Client.instance.myId))
            {
                Vector2 GameWindowCenterPosition = GameManager.players[Client.instance.myId].position;
                if (Vector2.Distance(CurrentWindowPosition, GameWindowCenterPosition)>10)
                {
                    MapTileSprites2D.DestroyList();
                    for (int i = -20; i < GameWindowCenterPosition.X + 20; i++)
                    {
                        for (int j = -20; j < GameWindowCenterPosition.Y + 20; j++)
                        {
                            int x = (int)GameWindowCenterPosition.X + i;
                            int y = (int)GameWindowCenterPosition.Y + j;
                            if (x < 0)
                            {
                                x = 0;
                            }
                            if (y < 0)
                            {
                                y = 0;
                            }
                            if (MainMap[y, x] != ".")
                            {
                                string tileName = mapTileNames[Convert.ToInt32(MainMap[y, x])];
                                for (int k = 0; k < mapTileColliders.Length; k++)
                                {
                                    if (tileName.Contains(mapTileColliders[k]))
                                    {
                                    }
                                }
                                new MapTileSprites2D(new Vector2(x, y), new Vector2(98, 66), (Image)Properties.Resources.ResourceManager.GetObject("_" + MainMap[y, x]), tileName);
                            }
                        }
                    }
                }
                CurrentWindowPosition = GameWindowCenterPosition;
            }
        }
        public static void LoadMapSprites(ImageList Images)
        {
            MapSprites = Images;
        }
    }
}
