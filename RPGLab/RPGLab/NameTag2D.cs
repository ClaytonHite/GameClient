using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.RPGLab
{
    public class NameTag2D
    {
        public Vector2 Position = null;
        public Vector2 Scale = null;
        public string Tag = "";
        public string PlayerName = "";
        public Bitmap nameTag = null;
        public Font Font;
        private static List<NameTag2D> NameTags;
        public NameTag2D(Vector2 Position, Vector2 Scale, string PlayerNames, string Tag)
        {
            this.Position = Position;
            this.Scale = Scale;
            this.PlayerName = PlayerNames;
            this.Tag = Tag;
            this.Font = new Font("TimesNewRoman", 10, FontStyle.Regular, GraphicsUnit.Pixel);
            Bitmap sprite = new Bitmap((int)this.Scale.X, (int)this.Scale.Y);
            nameTag = sprite;
            RegisterNameTag(this);
        }
        public static void onLoad()
        {
            NameTags = new List<NameTag2D>();
        }
        public void DestroySelf()
        {
            UnRegisterNameTag(this);
        }
        public static void RegisterNameTag(NameTag2D nameTag)
        {
            NameTags.Add(nameTag);
        }
        public static void UnRegisterNameTag(NameTag2D nameTag)
        {
            NameTags.Remove(nameTag);
        }
        public static List<NameTag2D> GetNameTags()
        {
            return NameTags;
        }
    }
}
