using RPGLab.Entities.Items.Attributes;
using RPGLab.RPGLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.Entities.Items.ItemTypes
{
    public class Container : Item
    {
        public int InventorySlots { get; set; }
        public int Price { get; set; }
        public ContainerInventory container;
        public static List<Container> containerList = new List<Container>();
        public static Dictionary<int, Container> containerDictionary = new Dictionary<int, Container>();
        public Container(int _id, string article, string _name, int _imageNumber, int _weight, bool _stackable, string _slotType, int _inventorySlots, int _price, List<Ammo> _ammoInInventory, List<Armor> _armorsInInventory, List<Consumable> _consumableInInventory, List<Currency> _currencyInInventory, List<Miscellaneous> _miscInInventory, List<Tool> _toolsInInventory, List<Weapon> _weaponsInInventory, List<Container> _containersInInventory) : base(_id, article, _name, _imageNumber, _weight, _stackable, _slotType)
        {
            InventorySlots = _inventorySlots;
            container = new ContainerInventory(InventorySlots);
            container.ammoInInventory = _ammoInInventory;
            container.armorsInInventory = _armorsInInventory;
            container.consumableInInventory = _consumableInInventory;
            container.currencyInInventory = _currencyInInventory;
            container.miscInInventory = _miscInInventory;
            container.toolsInInventory = _toolsInInventory;
            container.weaponsInInventory = _weaponsInInventory;
            container.containersInInventory = _containersInInventory;
            Price = _price;
        }
        public void RegisterContainer()
        {
            Item.items[ID] = new Container(ID, Article, Name, ImageNumber, Weight, Stackable, ItemType, InventorySlots, Price, container.ammoInInventory, container.armorsInInventory, container.consumableInInventory, container.currencyInInventory, container.miscInInventory, container.toolsInInventory, container.weaponsInInventory, container.containersInInventory);
            containerDictionary.Add(ID, this);
            container.ContainerSlots = InventorySlots;
        }
        public new Container Clone()
        {
            return new Container(ID, Article, Name, ImageNumber, Weight, Stackable, ItemType, InventorySlots, Price, container.ammoInInventory, container.armorsInInventory, container.consumableInInventory, container.currencyInInventory, container.miscInInventory, container.toolsInInventory, container.weaponsInInventory, container.containersInInventory);
        }
        public void DropItem(Container item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y] = new ItemsAtPosition(item, position);
        }
        public override Object GetItem()
        {
            return new Container(ID, Article, Name, ImageNumber, Weight, Stackable, ItemType, InventorySlots, Price, container.ammoInInventory, container.armorsInInventory, container.consumableInInventory, container.currencyInInventory, container.miscInInventory, container.toolsInInventory, container.weaponsInInventory, container.containersInInventory);
        }
    }
}
