using RPGLab.Entities.Items.Attributes;
using RPGLab.RPGLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.Entities.Items.ItemTypes
{
    public class Weapon : Item
    {
        public int Damage { get; set; }
        public bool Hands { get; set; }
        public int Price { get; set; }
        public string WeaponType { get; set; }
        public ItemAttribute Attribute { get; set; }
        public static List<Weapon> Weapons = new List<Weapon>();
        public static Dictionary<int, Weapon> WeaponsDictionary = new Dictionary<int, Weapon>();
        public Weapon(int _id, string article, string _name, int _imageNumber, int _weight, bool _stackable, string _slotType, string _weaponType, int _damage, bool _hands, int _price) : base(_id, article, _name, _imageNumber, _weight, _stackable, _slotType)
        {
            Damage = _damage;
            Hands = _hands;
            Price = _price;
            WeaponType = _weaponType;
        }
        public void RegisterWeapon()
        {
            Item.items[ID] = this;
            WeaponsDictionary.Add(ID, this);
        }
        public new Weapon Clone()
        {
            return new Weapon(ID, Article, Name, ImageNumber, Weight, Stackable, ItemType, WeaponType, Damage, Hands, Price);
        }
        public void DropItem(Weapon item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y] = new ItemsAtPosition(item, position);
        }
        public override Object GetItem()
        {
            return new Weapon(ID, Article, Name, ImageNumber, Weight, Stackable, ItemType, WeaponType, Damage, Hands, Price);
        }
    }
}
