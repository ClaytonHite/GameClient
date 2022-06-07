using RPGLab.RPGLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.Entities.Items.ItemTypes
{
    public class Ammo : Item
    {
        public int Damage { get; set; }
        public int Price { get; set; }
        public int AmountOfItem { get; set; }
        public static List<Ammo> ammoList = new List<Ammo>();
        public static Dictionary<int, Ammo> ammoDictionary = new Dictionary<int, Ammo>();
        public Ammo(int _id, string article, string _name, int _imageNumber, int _weight, bool _stackable, string _slotType, int _damage, int _price) : base(_id, article, _name, _imageNumber, _weight, _stackable, _slotType)
        {
            Damage = _damage;
            Price = _price;
        }
        public void RegisterAmmo()
        {
            Item.items[ID] = new Ammo(ID, Article, Name, ImageNumber, Weight, Stackable, ItemType, Damage, Price);
            ammoDictionary.Add(ID, this);
        }
        public new Ammo Clone()
        {
            return new Ammo(ID, Article, Name, ImageNumber, Weight, Stackable, ItemType, Damage, Price);
        }
        public void DropItem(Ammo item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y] = new ItemsAtPosition(item, position);
        }
    }
}
