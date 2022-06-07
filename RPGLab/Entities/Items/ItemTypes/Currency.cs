using RPGLab.RPGLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.Entities.Items.ItemTypes
{
    public class Currency : Item
    {
        public int Price { get; set; }
        public int AmountOfItem { get; set; }
        public static List<Currency> Currencies = new List<Currency>();
        public static Dictionary<int, Currency> CurrenciesDict = new Dictionary<int, Currency>();
        public Currency(int _id, string article, string _name, int _imageNumber, int _weight, bool _stackable, string _slotType, int _price) : base(_id, article, _name, _imageNumber, _weight, _stackable, _slotType)
        {
            Price = _price;
        }
        public void RegisterCurrency()
        {
            Item.items[ID] = new Currency(ID, Article, Name, ImageNumber, Weight, Stackable, ItemType, Price);
            CurrenciesDict.Add(ID, this);
        }
        public void SetAmountOfItem(int _amount)
        {
            AmountOfItem = _amount;
            switch (AmountOfItem)
            {
                case 1:
                    break;
                case 2:
                    ImageNumber = ImageNumber + 1;
                    break;
                case 3:
                    ImageNumber = ImageNumber + 2;
                    break;
                case 4:
                    ImageNumber = ImageNumber + 3;
                    break;
                default:
                    ImageNumber = ImageNumber + 4;
                    break;
            }
        }
        public new Currency Clone()
        {
            return new Currency(ID, Article, Name, ImageNumber, Weight, Stackable, ItemType, Price);
        }
        public void DropItem(Currency item, Vector2 position)
        {
            new ItemsAtPosition(item, position);
        }
    }
}
