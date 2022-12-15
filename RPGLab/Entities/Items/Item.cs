using Newtonsoft.Json;
using RPGLab.Entities.Items.ItemTypes;
using RPGLab.RPGLab;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.Entities.Items
{
    public class Item
    {
        public int ID;
        public string Article;
        public string Name;
        public int Weight;
        public int ImageNumber;
        public bool Stackable;
        public string ItemType;
        public static Item[] items = new Item[3000];
        public Item(int _id, string article, string _name, int _imageNumber, int _weight, bool _stackable, string _slotType)
        {
            this.ID = _id;
            this.Article = article;
            this.Name = _name;
            this.ImageNumber = _imageNumber;
            this.Weight = _weight;
            this.Stackable = _stackable;
            this.ItemType = _slotType;
        }
        public static void OnLoad()
        {
            using (StreamReader file = new StreamReader(@".\JSONFiles\Ammos.json"))
            {
                string json = file.ReadToEnd();
                Ammo.ammoList = JsonConvert.DeserializeObject<List<Ammo>>(json);
            }
            using (StreamReader file = new StreamReader(@".\JSONFiles\Armors.json"))
            {
                string json = file.ReadToEnd();
                Armor.Armors = JsonConvert.DeserializeObject<List<Armor>>(json);
            }
            using (StreamReader file = new StreamReader(@".\JSONFiles\Currency.json"))
            {
                string json = file.ReadToEnd();
                Currency.Currencies = JsonConvert.DeserializeObject<List<Currency>>(json);
            }
            using (StreamReader file = new StreamReader(@".\JSONFiles\Consumable.json"))
            {
                string json = file.ReadToEnd();
                Consumable.Consumables = JsonConvert.DeserializeObject<List<Consumable>>(json);
            }
            using (StreamReader file = new StreamReader(@".\JSONFiles\Miscellaneous.json"))
            {
                string json = file.ReadToEnd();
                Miscellaneous.miscellaneousList = JsonConvert.DeserializeObject<List<Miscellaneous>>(json);
            }
            using (StreamReader file = new StreamReader(@".\JSONFiles\Tools.json"))
            {
                string json = file.ReadToEnd();
                Tool.Tools = JsonConvert.DeserializeObject<List<Tool>>(json);
            }
            using (StreamReader file = new StreamReader(@".\JSONFiles\Weapons.json"))
            {
                string json = file.ReadToEnd();
                Weapon.Weapons = JsonConvert.DeserializeObject<List<Weapon>>(json);
            }
            Log.Normal(DateTime.Now + $" -- Loaded Items...");
            foreach (Ammo ammo in Ammo.ammoList)
            {
                ammo.RegisterAmmo();
            }
            foreach (Armor armor in Armor.Armors)
            {
                armor.RegisterArmor();
            }
            foreach (Currency currencies in Currency.Currencies)
            {
                currencies.RegisterCurrency();
            }
            foreach (Consumable consumable in Consumable.Consumables)
            {
                consumable.RegisterConsumable();
            }
            foreach (Miscellaneous miscellaneous in Miscellaneous.miscellaneousList)
            {
                miscellaneous.RegisterMiscellaneous();
            }
            foreach (Tool tool in Tool.Tools)
            {
                tool.RegisterTool();
            }
            foreach (Weapon weapon in Weapon.Weapons)
            {
                weapon.RegisterWeapon();
            }
        }
        public Item Clone()
        {
            return new Item(ID, Article, Name, ImageNumber, Weight, Stackable, ItemType);
        }
        public virtual Object GetItem()
        {
            return new Item(ID, Article, Name, ImageNumber, Weight, Stackable, ItemType);
        }
    }
}
