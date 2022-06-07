using RPGLab.Entities.Items.ItemTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.Entities.Items.Attributes
{
    public class ContainerInventory
    {
        public int ContainerSlots;
        public int ContainerUsedSlots;
        public List<Item> itemsInInventory = new List<Item>();
        public List<Ammo> ammoInInventory = new List<Ammo>();
        public List<Armor> armorsInInventory = new List<Armor>();
        public List<Consumable> consumableInInventory = new List<Consumable>();
        public List<Currency> currencyInInventory = new List<Currency>();
        public List<Miscellaneous> miscInInventory = new List<Miscellaneous>();
        public List<Tool> toolsInInventory = new List<Tool>();
        public List<Weapon> weaponsInInventory = new List<Weapon>();
        public List<Container> containersInInventory = new List<Container>();
        public ContainerInventory(int containerSlots)
        {
            ContainerSlots = containerSlots;
            foreach (Item item in ammoInInventory)
            {
                AddItem(item);
            }
            foreach (Item item in armorsInInventory)
            {
                AddItem(item);
            }
            foreach (Item item in consumableInInventory)
            {
                AddItem(item);
            }
            foreach (Item item in currencyInInventory)
            {
                AddItem(item);
            }
            foreach (Item item in miscInInventory)
            {
                AddItem(item);
            }
            foreach (Item item in toolsInInventory)
            {
                AddItem(item);
            }
            foreach (Item item in weaponsInInventory)
            {
                AddItem(item);
            }
            foreach (Item item in containersInInventory)
            {
                AddItem(item);
            }
        }
        public void AddItem(Item _item)
        {
            if (ContainerSlots > itemsInInventory.Count)
            {
                itemsInInventory.Add(_item);
            }
        }
        public void AddItem(Ammo _item)
        {
            if (ContainerSlots > itemsInInventory.Count)
            {
                itemsInInventory.Add(_item);
                ammoInInventory.Add(_item);
            }
        }
        public void AddItem(Armor _item)
        {
            if (ContainerSlots > itemsInInventory.Count)
            {
                itemsInInventory.Add(_item);
                armorsInInventory.Add(_item);
            }
        }
        public void AddItem(Consumable _item)
        {
            if (ContainerSlots > itemsInInventory.Count)
            {
                itemsInInventory.Add(_item);
                consumableInInventory.Add(_item);
            }
        }
        public void AddItem(Currency _item)
        {
            if (ContainerSlots > itemsInInventory.Count)
            {
                itemsInInventory.Add(_item);
                currencyInInventory.Add(_item);
            }
        }
        public void AddItem(Miscellaneous _item)
        {
            if (ContainerSlots > itemsInInventory.Count)
            {
                itemsInInventory.Add(_item);
                miscInInventory.Add(_item);
            }
        }
        public void AddItem(Tool _item)
        {
            if (ContainerSlots > itemsInInventory.Count)
            {
                itemsInInventory.Add(_item);
                toolsInInventory.Add(_item);
            }
        }
        public void AddItem(Weapon _item)
        {
            if (ContainerSlots > itemsInInventory.Count)
            {
                itemsInInventory.Add(_item);
                weaponsInInventory.Add(_item);
            }
        }
        public void AddItem(Container _item)
        {
            if (ContainerSlots > itemsInInventory.Count)
            {
                itemsInInventory.Add(_item);
                containersInInventory.Add(_item);
            }
        }
    }
}
