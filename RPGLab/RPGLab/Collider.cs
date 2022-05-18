using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.RPGLab
{
    public class Collider
    {
        public bool Walkable { get; set; }
        public Vector2 Position;
        public string Tag;
        public static Collider[,] colliderArray = new Collider[TileMap.mapSize, TileMap.mapSize];
        public Collider(Vector2 Position, bool walkable, string tag)
        {
            this.Position = Position;
            this.Walkable = walkable;
            this.Tag = tag;
            RegisterColliderArray(this);
        }
        public static bool CheckForCollider(Vector2 position)
        {
            if (colliderArray[(int)position.X, (int)position.Y] == null)
            {
                return true;
            }
            if (!colliderArray[(int)position.X, (int)position.Y].Walkable)
            {
                return false;
            }
            return true;
        }
        public static Collider GetColliders(Vector2 position)
        {
            return colliderArray[(int)position.X, (int)position.Y];
        }
        public void DestroySelf()
        {
            UnregisterColliderArray(this);
        }
        public void RegisterColliderArray(Collider collider)
        {
            colliderArray[(int)collider.Position.X, (int)collider.Position.Y] = collider;
        }
        public void UnregisterColliderArray(Collider collider)
        {
            colliderArray[(int)collider.Position.X, (int)collider.Position.Y] = null;
        }
    }
}
