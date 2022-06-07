using RPGLab.Entities.Items.ItemTypes;
using RPGLab.Networking;
using RPGLab.RPGLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.Entities.Items
{
    public class ItemsAtPosition
    {
        public List<Item> itemsAtPosition;
        public List<Ammo> ammoAtPosition;
        public List<Armor> armorsAtPosition;
        public List<Consumable> consumableAtPosition;
        public List<Currency> currencyAtPosition;
        public List<Miscellaneous> miscAtPosition;
        public List<Tool> toolsAtPosition;
        public List<Weapon> weaponsAtPosition;
        public List<Container> containersAtPosition;
        public ItemsAtPosition()
        {
            itemsAtPosition = new List<Item>();
            ammoAtPosition = new List<Ammo>();
            armorsAtPosition = new List<Armor>();
            consumableAtPosition = new List<Consumable>();
            currencyAtPosition = new List<Currency>();
            miscAtPosition = new List<Miscellaneous>();
            toolsAtPosition = new List<Tool>();
            weaponsAtPosition = new List<Weapon>();
            containersAtPosition = new List<Container>();
        }
        public ItemsAtPosition(Item _item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].itemsAtPosition.Add(_item);
            new Item2D(position, new Vector2(48, 48), _item.ImageNumber, _item.Name);
        }
        #region ADD or Remove or Check for items at position
        public ItemsAtPosition(Ammo _item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].itemsAtPosition.Add(_item);
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].ammoAtPosition.Add(_item);
            new Item2D(position, new Vector2(48, 48), _item.ImageNumber, _item.Name);
        }
        public ItemsAtPosition(Armor _item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].itemsAtPosition.Add(_item);
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].armorsAtPosition.Add(_item);
            new Item2D(position, new Vector2(48, 48), _item.ImageNumber, _item.Name);
        }
        public ItemsAtPosition(Consumable _item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].itemsAtPosition.Add(_item);
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].consumableAtPosition.Add(_item);
            new Item2D(position, new Vector2(48, 48), _item.ImageNumber, _item.Name);
        }
        public ItemsAtPosition(Currency _item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].itemsAtPosition.Add(_item);
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].currencyAtPosition.Add(_item);
            new Item2D(position, new Vector2(48, 48), _item.ImageNumber, _item.Name);
        }
        public ItemsAtPosition(Miscellaneous _item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].itemsAtPosition.Add(_item);
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].miscAtPosition.Add(_item);
        }
        public ItemsAtPosition(Tool _item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].itemsAtPosition.Add(_item);
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].toolsAtPosition.Add(_item);
        }
        public ItemsAtPosition(Weapon _item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].itemsAtPosition.Add(_item);
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].weaponsAtPosition.Add(_item);
        }
        public ItemsAtPosition(Container _item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].itemsAtPosition.Add(_item);
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].containersAtPosition.Add(_item);
        }

        public static Item GetItemOnTopAtPosition(Vector2 position)
        {
            return TileMap.itemsAtPositions[(int)position.X, (int)position.Y].itemsAtPosition.LastOrDefault<Item>();
        }
        public static Ammo GetSpecificItemOnTop(Vector2 position, Ammo item)
        {
            return TileMap.itemsAtPositions[(int)position.X, (int)position.Y].ammoAtPosition.LastOrDefault<Ammo>();
        }
        public static void RemoveSpecificItemOnTop(Vector2 position, Ammo item)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].ammoAtPosition.Remove(item);
        }
        public static Armor GetSpecificItemOnTop(Vector2 position, Armor item)
        {
            return TileMap.itemsAtPositions[(int)position.X, (int)position.Y].armorsAtPosition.LastOrDefault<Armor>();
        }
        public static void RemoveSpecificItemOnTop(Vector2 position, Armor item)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].armorsAtPosition.Remove(item);
        }
        public static Consumable GetSpecificItemOnTop(Vector2 position, Consumable item)
        {
            return TileMap.itemsAtPositions[(int)position.X, (int)position.Y].consumableAtPosition.LastOrDefault<Consumable>();
        }
        public static void RemoveSpecificItemOnTop(Vector2 position, Consumable item)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].consumableAtPosition.Remove(item);
        }
        public static Container GetSpecificItemOnTop(RPGLab.Vector2 position, Container item)
        {
            return TileMap.itemsAtPositions[(int)position.X, (int)position.Y].containersAtPosition.LastOrDefault<Container>();
        }
        public static void RemoveSpecificItemOnTop(Vector2 position, Container item)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].containersAtPosition.Remove(item);
        }
        public static Currency GetSpecificItemOnTop(Vector2 position, Currency item)
        {
            return TileMap.itemsAtPositions[(int)position.X, (int)position.Y].currencyAtPosition.LastOrDefault<Currency>();
        }
        public static void RemoveSpecificItemOnTop(Vector2 position, Currency item)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].currencyAtPosition.Remove(item);
        }
        public static Miscellaneous GetSpecificItemOnTop(Vector2 position, Miscellaneous item)
        {
            return TileMap.itemsAtPositions[(int)position.X, (int)position.Y].miscAtPosition.LastOrDefault<Miscellaneous>();
        }
        public static void RemoveSpecificItemOnTop(Vector2 position, Miscellaneous item)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].miscAtPosition.Remove(item);
        }
        public static Tool GetSpecificItemOnTop(Vector2 position, Tool item)
        {
            return TileMap.itemsAtPositions[(int)position.X, (int)position.Y].toolsAtPosition.LastOrDefault<Tool>();
        }
        public static void RemoveSpecificItemOnTop(Vector2 position, Tool item)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].toolsAtPosition.Remove(item);
        }
        public static Weapon GetSpecificItemOnTop(Vector2 position, Weapon item)
        {
            return TileMap.itemsAtPositions[(int)position.X, (int)position.Y].weaponsAtPosition.LastOrDefault<Weapon>();
        }
        public static void RemoveSpecificItemOnTop(Vector2 position, Weapon item)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].weaponsAtPosition.Remove(item);
        }
        public void Remove(Item _item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].itemsAtPosition.Remove(_item);
        }
        public void Remove(Ammo _item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].itemsAtPosition.Remove(_item);
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].ammoAtPosition.Add(_item);
        }
        public void Remove(Armor _item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].itemsAtPosition.Remove(_item);
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].armorsAtPosition.Remove(_item);
        }
        public void Remove(Consumable _item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].itemsAtPosition.Remove(_item);
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].consumableAtPosition.Remove(_item);
        }
        public void Remove(Currency _item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].itemsAtPosition.Remove(_item);
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].currencyAtPosition.Remove(_item);
        }
        public void Remove(Miscellaneous _item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].itemsAtPosition.Remove(_item);
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].miscAtPosition.Remove(_item);
        }
        public void Remove(Tool _item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].itemsAtPosition.Remove(_item);
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].toolsAtPosition.Remove(_item);
        }
        public void Remove(Weapon _item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].itemsAtPosition.Remove(_item);
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].weaponsAtPosition.Remove(_item);
        }
        public void Remove(Container _item, Vector2 position)
        {
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].itemsAtPosition.Remove(_item);
            TileMap.itemsAtPositions[(int)position.X, (int)position.Y].containersAtPosition.Remove(_item);
        }
        #endregion
    }
}
