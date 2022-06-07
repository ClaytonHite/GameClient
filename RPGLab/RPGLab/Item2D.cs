using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.RPGLab
{
    public class Item2D
    {
        public Vector2 Position = null;
        public Vector2 Scale = null;
        public int ImageNumber;
        public string Tag = "";
        private static List<Item2D> ItemSprites = new List<Item2D>();
        public Item2D(Vector2 Position, Vector2 Scale, int imageNumber, string Tag)
        {
            this.Position = Position;
            this.Scale = Scale;
            this.ImageNumber = imageNumber;
            this.Tag = Tag;
            RegisterSprite(this);
        }
        public static void DestroyList()
        {
            ItemSprites.Clear();
        }
        public void DestroySelf()
        {
            Log.Info($"[Item2D]({Tag}) - has been destroyed!");
            UnRegisterSprite(this);
        }
        public static void RegisterSprite(Item2D sprite)
        {
            ItemSprites.Add(sprite);
        }
        public static void UnRegisterSprite(Item2D sprite)
        {
            ItemSprites.Remove(sprite);
        }
        public static List<Item2D> GetSprites()
        {
            return ItemSprites;
        }
    }
}
