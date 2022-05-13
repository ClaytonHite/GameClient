using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using RPGLab.Networking;

namespace RPGLab.RPGLab
{
    public class Sprite2D
    {
        public Vector2 Position = null;
        public Vector2 Scale = null;
        public Image Image;
        public string Tag = "";
        public Bitmap Sprite = null;
        private static List<Sprite2D> Sprites = new List<Sprite2D>();
        public Sprite2D(Vector2 Position, Vector2 Scale, Image CharImage, string Tag)
        {
            this.Position = Position;
            this.Scale = Scale;
            this.Image = CharImage;
            this.Tag = Tag;

            Image tmp = CharImage;
            Bitmap sprite = new Bitmap(tmp, (int)this.Scale.X, (int)this.Scale.Y);
            Sprite = sprite;

            Log.Info($"[SPRITE2D]({Tag}) - has been registered! at X{Position.X} Y{Position.Y}");
            RegisterSprite(this);
        }
        public void DestroySelf()
        {
            Log.Info($"[SPRITE2D]({Tag}) - has been destroyed!");
            UnRegisterSprite(this);
        }
        public static void RegisterSprite(Sprite2D sprite)
        {
            Sprites.Add(sprite);
        }
        public static void UnRegisterSprite(Sprite2D sprite)
        {
            Sprites.Remove(sprite);
        }
        public static List<Sprite2D> GetSprites()
        {
            return Sprites;
        }
    }
}
