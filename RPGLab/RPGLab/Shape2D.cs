using RPGLab.Networking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.RPGLab
{
    public class Shape2D
    {
        public Vector2 Position = null;
        public Vector2 Scale = null;
        public string Tag = "";
        private static List<Shape2D> Shapes = new List<Shape2D>();

        public Shape2D(Vector2 Position, Vector2 Scale, string Tag)
        {
            this.Position = Position;
            this.Scale = Scale;
            this.Tag = Tag;

            Log.Info($"[SHAPE2D]({Tag}) - has been registered!");
            RegisterShape(this);
        }

        public void DestroySelf()
        {
            Log.Info($"[SHAPE2D]({Tag}) - has been destroyed!");
            UnRegisterShape(this);
        }
        public static void RegisterShape(Shape2D shape)
        {
            Shapes.Add(shape);
        }
        public static void UnRegisterShape(Shape2D shape)
        {
            Shapes.Remove(shape);
        }
        public static List<Shape2D> GetShapes()
        {
            return Shapes;
        }
    }
}
