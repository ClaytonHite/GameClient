using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.RPGLab
{
    public class MapTileSprites2D
    {
        public Vector2 Position = null;
        public Vector2 Scale = null;
        public int ImageNumber;
        public string Tag = "";
        private static List<MapTileSprites2D> MapTileSprites = new List<MapTileSprites2D>();
        public MapTileSprites2D(Vector2 Position, Vector2 Scale, int imageNumber, string Tag)
        {
            this.Position = Position;
            this.Scale = Scale;
            this.ImageNumber = imageNumber;
            this.Tag = Tag;

            Log.Info($"[MapTileSprites2D]({Tag}) - has been registered! at X{Position.X} Y{Position.Y}");
            RegisterSprite(this);
        }
        public static void DestroyList()
        {
            MapTileSprites.Clear();
        }
        public void DestroySelf()
        {
            Log.Info($"[MapTileSprites2D]({Tag}) - has been destroyed!");
            UnRegisterSprite(this);
        }
        public static void RegisterSprite(MapTileSprites2D sprite)
        {
            MapTileSprites.Add(sprite);
        }
        public static void UnRegisterSprite(MapTileSprites2D sprite)
        {
            MapTileSprites.Remove(sprite);
        }
        public static List<MapTileSprites2D> GetSprites()
        {
            return MapTileSprites;
        }
    }
}
