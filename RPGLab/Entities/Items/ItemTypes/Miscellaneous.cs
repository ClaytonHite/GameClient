using RPGLab.RPGLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.Entities.Items.ItemTypes
{
    public class Miscellaneous : Item
    {
        public int AmountOfItem { get; set; }
        public static List<Miscellaneous> miscellaneousList = new List<Miscellaneous>();
        public static Dictionary<int, Miscellaneous> miscellaneousDictionary = new Dictionary<int, Miscellaneous>();
        public Miscellaneous(int _id, string article, string _name, int _imageNumber, int _weight, bool _stackable, string _slotType) : base(_id, article, _name, _imageNumber, _weight, _stackable, _slotType)
        {

        }
        public void RegisterMiscellaneous()
        {
            Item.items[ID] = this;
            miscellaneousDictionary.Add(ID, this);
        }
        public new Miscellaneous Clone()
        {
            return new Miscellaneous(ID, Article, Name, ImageNumber, Weight, Stackable, ItemType);
        }
        public void DropItem(Miscellaneous item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y] = new ItemsAtPosition(item, position);
        }
        public override Object GetItem()
        {
            return new Miscellaneous(ID, Article, Name, ImageNumber, Weight, Stackable, ItemType);
        }
    }
}
