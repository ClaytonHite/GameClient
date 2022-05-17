using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.RPGLab
{
    public class Collider
    {
        public static int colliderId = 0;
        public bool Walkable { get; set; }
        public Vector2 Position;
        public static List<Collider> Colliders = new List<Collider>();
        public Collider(Vector2 Position, bool Walkable)
        {
            colliderId++;
            this.Position = Position;
            this.Walkable = Walkable;
            Colliders.Add(this);
        }
        public static bool CheckForCollider(Vector2 position)
        {
            foreach(Collider collider in Colliders)
            {
                if (collider.Position.X == position.X && collider.Position.Y == position.Y)
                {
                    if(!collider.Walkable)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void DestroySelf()
        {
            UnregisterCollider(this);
        }

        public static void UnregisterCollider(Collider collider)
        {
            Colliders.Remove(collider);
        }
    }
}
