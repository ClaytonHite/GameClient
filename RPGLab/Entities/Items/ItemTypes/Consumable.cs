using RPGLab.RPGLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.Entities.Items.ItemTypes
{
    public class Consumable : Item
    {
        public int HealthAmountPerTick { get; set; }
        public int ManaAmountPerTick { get; set; }
        public int FullDuration { get; set; }
        public int Price { get; set; }
        public int AmountOfItem { get; set; }
        public static List<Consumable> Consumables = new List<Consumable>();
        public static Dictionary<int, Consumable> ConsumableDictionary = new Dictionary<int, Consumable>();
        public Consumable(int _id, string article, string _name, int _imageNumber, int _weight, bool _stackable, string _slotType, int _healthAmountPerTick, int _manaAmountPerTick, int _fullDuration, int _price) : base(_id, article, _name, _imageNumber, _weight, _stackable, _slotType)
        {
            HealthAmountPerTick = _healthAmountPerTick;
            ManaAmountPerTick = _manaAmountPerTick;
            FullDuration = _fullDuration;
            Price = _price;
        }
        public void RegisterConsumable()
        {
            Item.items[ID] = new Consumable(ID, Article, Name, ImageNumber, Weight, Stackable, ItemType, HealthAmountPerTick, ManaAmountPerTick, FullDuration, Price);
            ConsumableDictionary.Add(ID, this);
        }
        public static Consumable GetConsumable(int itemID)
        {
            foreach (Consumable food in Consumables)
            {
                if (food.ID == itemID)
                {
                    return food;
                }
            }
            return null;
        }
        public new Consumable Clone()
        {
            return new Consumable(ID, Article, Name, ImageNumber, Weight, Stackable, ItemType, HealthAmountPerTick, ManaAmountPerTick, FullDuration, Price);
        }
        public void DropItem(Consumable item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y] = new ItemsAtPosition(item, position);
        }
        public override Object GetItem()
        {
            return new Consumable(ID, Article, Name, ImageNumber, Weight, Stackable, ItemType, HealthAmountPerTick, ManaAmountPerTick, FullDuration, Price);
        }
    }
}
