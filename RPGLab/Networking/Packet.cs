using Newtonsoft.Json.Linq;
using RPGLab.Entities.Items;
using RPGLab.Entities.Items.ItemTypes;
using RPGLab.Entities.Players;
using RPGLab.RPGLab;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/// <summary>Sent from server to client.</summary>
public enum ServerPackets
{
    welcome = 1,
    spawnPlayer,
    Login,
    CreateAccount,
    characterSelect,
    playerPosition,
    CreateCharacter,
    PopulateMonsters,
    playerCombat,
    MonsterUpdate,
    UpdateMonsterPosition,
    PlayerDamageDone,
    MonsterDamageDone,
    updatePlayer,
    wrongAccountorPassword,
    ChatBox,
    DisconnectPlayer,
    DropItemOnGround
}

/// <summary>Sent from client to server.</summary>
public enum ClientPackets
{
    welcomeReceived = 1,
    Login,
    createAccount,
    CharacterSelect,
    playerMovement,
    createCharacter,
    playerCombat,
    addSkill,
    CharacterToDelete,
    AccountToDelete,
    ChatBox,
    ClientItemToPickUp
}

public class Packet : IDisposable
{
    private List<byte> buffer;
    private byte[] readableBuffer;
    private int readPos;

    /// <summary>Creates a new empty packet (without an ID).</summary>
    public Packet()
    {
        buffer = new List<byte>(); // Initialize buffer
        readPos = 0; // Set readPos to 0
    }

    /// <summary>Creates a new packet with a given ID. Used for sending.</summary>
    /// <param name="_id">The packet ID.</param>
    public Packet(int _id)
    {
        buffer = new List<byte>(); // Initialize buffer
        readPos = 0; // Set readPos to 0

        Write(_id); // Write packet id to the buffer
    }

    /// <summary>Creates a packet from which data can be read. Used for receiving.</summary>
    /// <param name="_data">The bytes to add to the packet.</param>
    public Packet(byte[] _data)
    {
        buffer = new List<byte>(); // Initialize buffer
        readPos = 0; // Set readPos to 0

        SetBytes(_data);
    }

    #region Functions
    /// <summary>Sets the packet's content and prepares it to be read.</summary>
    /// <param name="_data">The bytes to add to the packet.</param>
    public void SetBytes(byte[] _data)
    {
        Write(_data);
        readableBuffer = buffer.ToArray();
    }

    /// <summary>Inserts the length of the packet's content at the start of the buffer.</summary>
    public void WriteLength()
    {
        buffer.InsertRange(0, BitConverter.GetBytes(buffer.Count)); // Insert the byte length of the packet at the very beginning
    }

    /// <summary>Inserts the given int at the start of the buffer.</summary>
    /// <param name="_value">The int to insert.</param>
    public void InsertInt(int _value)
    {
        buffer.InsertRange(0, BitConverter.GetBytes(_value)); // Insert the int at the start of the buffer
    }

    /// <summary>Gets the packet's content in array form.</summary>
    public byte[] ToArray()
    {
        readableBuffer = buffer.ToArray();
        return readableBuffer;
    }

    /// <summary>Gets the length of the packet's content.</summary>
    public int Length()
    {
        return buffer.Count; // Return the length of buffer
    }

    /// <summary>Gets the length of the unread data contained in the packet.</summary>
    public int UnreadLength()
    {
        return Length() - readPos; // Return the remaining length (unread)
    }

    /// <summary>Resets the packet instance to allow it to be reused.</summary>
    /// <param name="_shouldReset">Whether or not to reset the packet.</param>
    public void Reset(bool _shouldReset = true)
    {
        if (_shouldReset)
        {
            buffer.Clear(); // Clear buffer
            readableBuffer = null;
            readPos = 0; // Reset readPos
        }
        else
        {
            readPos -= 4; // "Unread" the last read int
        }
    }
    #endregion

    #region Write Data
    /// <summary>Adds a byte to the packet.</summary>
    /// <param name="_value">The byte to add.</param>
    public void Write(byte _value)
    {
        buffer.Add(_value);
    }
    /// <summary>Adds an array of bytes to the packet.</summary>
    /// <param name="_value">The byte array to add.</param>
    public void Write(byte[] _value)
    {
        buffer.AddRange(_value);
    }
    /// <summary>Adds a short to the packet.</summary>
    /// <param name="_value">The short to add.</param>
    public void Write(short _value)
    {
        buffer.AddRange(BitConverter.GetBytes(_value));
    }
    /// <summary>Adds an int to the packet.</summary>
    /// <param name="_value">The int to add.</param>
    public void Write(int _value)
    {
        buffer.AddRange(BitConverter.GetBytes(_value));
    }
    /// <summary>Adds a long to the packet.</summary>
    /// <param name="_value">The long to add.</param>
    public void Write(long _value)
    {
        buffer.AddRange(BitConverter.GetBytes(_value));
    }
    /// <summary>Adds a float to the packet.</summary>
    /// <param name="_value">The float to add.</param>
    public void Write(float _value)
    {
        buffer.AddRange(BitConverter.GetBytes(_value));
    }
    /// <summary>Adds a bool to the packet.</summary>
    /// <param name="_value">The bool to add.</param>
    public void Write(bool _value)
    {
        buffer.AddRange(BitConverter.GetBytes(_value));
    }
    /// <summary>Adds a string to the packet.</summary>
    /// <param name="_value">The string to add.</param>
    public void Write(string _value)
    {
        Write(_value.Length); // Add the length of the string to the packet
        buffer.AddRange(Encoding.ASCII.GetBytes(_value)); // Add the string itself
    }
    /// <summary>Adds a Vector2 to the packet.</summary>
    /// <param name="_value">The Vector2 to add.</param>
    public void Write(Vector2 _value)
    {
        Write(_value.X);
        Write(_value.Y);
    }
    /// <summary>Adds a Player to the packet.</summary>
    /// <param name="_value">The Player to add.</param>
    public void Write(Player _value)
    {
        Write(_value.id);
        Write(_value.username);
        Write(_value.playerInfo.playerAvatar);
        Write(_value.playerInfo.playerRace);
        Write(_value.playerInfo.playerClass);
        Write(_value.playerInfo.playerBusy);
        Write(_value.playerInfo.isStealth);
        Write(_value.stats.strength);
        Write(_value.stats.dexterity);
        Write(_value.stats.constitution);
        Write(_value.stats.intellect);
        Write(_value.stats.charisma);
        Write(_value.stats.level);
        Write(_value.stats.currentHitPoints);
        Write(_value.stats.maxHitPoints);
        Write(_value.stats.currentManaPoints);
        Write(_value.stats.maxManaPoints);
        Write(_value.stats.playerCarryingWeight);
        Write(_value.stats.playerExperience);
        Write(_value.stats.ExperienceRequired);
        Write(_value.stats.playerSkillPoints);
        Write(_value.position);
    }
    /// <summary>Adds a Container to the packet.</summary>
    /// <param name="_value">The Container to add.</param>
    public void Write(Container _value)
    {
        Write(_value.ID);
        Write(_value.Article);
        Write(_value.Name);
        Write(_value.ImageNumber);
        Write(_value.Weight);
        Write(_value.Stackable);
        Write(_value.ItemType);
        Write(_value.InventorySlots);
        Write(_value.Price);
        Write(_value.container.ammoInInventory.Count);
        foreach (Ammo ammo in _value.container.ammoInInventory)
        {
            Write(ammo);
        }
        Write(_value.container.armorsInInventory.Count);
        foreach (Armor armors in _value.container.armorsInInventory)
        {
            Write(armors);
        }
        Write(_value.container.consumableInInventory.Count);
        foreach (Consumable consumable in _value.container.consumableInInventory)
        {
            Write(consumable);
        }
        Write(_value.container.containersInInventory.Count);
        foreach (Container container in _value.container.containersInInventory)
        {
            Write(container);
        }
        Write(_value.container.currencyInInventory.Count);
        foreach (Currency currency in _value.container.currencyInInventory)
        {
            Write(currency);
        }
        Write(_value.container.miscInInventory.Count);
        foreach (Miscellaneous misc in _value.container.miscInInventory)
        {
            Write(misc);
        }
        Write(_value.container.toolsInInventory.Count);
        foreach (Tool tool in _value.container.toolsInInventory)
        {
            Write(tool);
        }
        Write(_value.container.weaponsInInventory.Count);
        foreach (Weapon weapon in _value.container.weaponsInInventory)
        {
            Write(weapon);
        }
    }
    public void Write(Item _value)
    {
        Write(_value.ID);
        Write(_value.Article);
        Write(_value.Name);
        Write(_value.ImageNumber);
        Write(_value.Weight);
        Write(_value.Stackable);
        Write(_value.ItemType);
    }
    public void Write(Ammo _value)
    {
        Write(_value.ID);
        Write(_value.Article);
        Write(_value.Name);
        Write(_value.ImageNumber);
        Write(_value.Weight);
        Write(_value.Stackable);
        Write(_value.ItemType);
        Write(_value.Damage);
        Write(_value.Price);
    }
    public void Write(Armor _value)
    {
        Write(_value.ID);
        Write(_value.Article);
        Write(_value.Name);
        Write(_value.ImageNumber);
        Write(_value.Weight);
        Write(_value.Stackable);
        Write(_value.ItemType);
        Write(_value.ArmorType);
        Write(_value.ArmorAmount);
        Write(_value.Price);
    }
    public void Write(Consumable _value)
    {
        Write(_value.ID);
        Write(_value.Article);
        Write(_value.Name);
        Write(_value.ImageNumber);
        Write(_value.Weight);
        Write(_value.Stackable);
        Write(_value.ItemType);
        Write(_value.HealthAmountPerTick);
        Write(_value.ManaAmountPerTick);
        Write(_value.FullDuration);
        Write(_value.Price);
    }
    public void Write(Currency _value)
    {
        Write(_value.ID);
        Write(_value.Article);
        Write(_value.Name);
        Write(_value.ImageNumber);
        Write(_value.Weight);
        Write(_value.Stackable);
        Write(_value.ItemType);
        Write(_value.Price);
    }
    public void Write(Miscellaneous _value)
    {
        Write(_value.ID);
        Write(_value.Article);
        Write(_value.Name);
        Write(_value.ImageNumber);
        Write(_value.Weight);
        Write(_value.Stackable);
        Write(_value.ItemType);
    }
    public void Write(Tool _value)
    {
        Write(_value.ID);
        Write(_value.Article);
        Write(_value.Name);
        Write(_value.ImageNumber);
        Write(_value.Weight);
        Write(_value.Stackable);
        Write(_value.ItemType);
        Write(_value.ToolType);
        Write(_value.ToolDamage);
        Write(_value.Price);
    }
    public void Write(Weapon _value)
    {
        Write(_value.ID);
        Write(_value.Article);
        Write(_value.Name);
        Write(_value.ImageNumber);
        Write(_value.Weight);
        Write(_value.Stackable);
        Write(_value.ItemType);
        Write(_value.WeaponType);
        Write(_value.Damage);
        Write(_value.Hands);
        Write(_value.Price);
    }
    #endregion

    #region Read Data
    /// <summary>Reads a byte from the packet.</summary>
    /// <param name="_moveReadPos">Whether or not to move the buffer's read position.</param>
    public byte ReadByte(bool _moveReadPos = true)
    {
        if (buffer.Count > readPos)
        {
            // If there are unread bytes
            byte _value = readableBuffer[readPos]; // Get the byte at readPos' position
            if (_moveReadPos)
            {
                // If _moveReadPos is true
                readPos += 1; // Increase readPos by 1
            }
            return _value; // Return the byte
        }
        else
        {
            throw new Exception("Could not read value of type 'byte'!");
        }
    }

    /// <summary>Reads an array of bytes from the packet.</summary>
    /// <param name="_length">The length of the byte array.</param>
    /// <param name="_moveReadPos">Whether or not to move the buffer's read position.</param>
    public byte[] ReadBytes(int _length, bool _moveReadPos = true)
    {
        if (buffer.Count > readPos)
        {
            // If there are unread bytes
            byte[] _value = buffer.GetRange(readPos, _length).ToArray(); // Get the bytes at readPos' position with a range of _length
            if (_moveReadPos)
            {
                // If _moveReadPos is true
                readPos += _length; // Increase readPos by _length
            }
            return _value; // Return the bytes
        }
        else
        {
            throw new Exception("Could not read value of type 'byte[]'!");
        }
    }

    /// <summary>Reads a short from the packet.</summary>
    /// <param name="_moveReadPos">Whether or not to move the buffer's read position.</param>
    public short ReadShort(bool _moveReadPos = true)
    {
        if (buffer.Count > readPos)
        {
            // If there are unread bytes
            short _value = BitConverter.ToInt16(readableBuffer, readPos); // Convert the bytes to a short
            if (_moveReadPos)
            {
                // If _moveReadPos is true and there are unread bytes
                readPos += 2; // Increase readPos by 2
            }
            return _value; // Return the short
        }
        else
        {
            throw new Exception("Could not read value of type 'short'!");
        }
    }

    /// <summary>Reads an int from the packet.</summary>
    /// <param name="_moveReadPos">Whether or not to move the buffer's read position.</param>
    public int ReadInt(bool _moveReadPos = true)
    {
        if (buffer.Count > readPos)
        {
            // If there are unread bytes
            int _value = BitConverter.ToInt32(readableBuffer, readPos); // Convert the bytes to an int
            if (_moveReadPos)
            {
                // If _moveReadPos is true
                readPos += 4; // Increase readPos by 4
            }
            return _value; // Return the int
        }
        else
        {
            throw new Exception("Could not read value of type 'int'!");
        }
    }

    /// <summary>Reads a long from the packet.</summary>
    /// <param name="_moveReadPos">Whether or not to move the buffer's read position.</param>
    public long ReadLong(bool _moveReadPos = true)
    {
        if (buffer.Count > readPos)
        {
            // If there are unread bytes
            long _value = BitConverter.ToInt64(readableBuffer, readPos); // Convert the bytes to a long
            if (_moveReadPos)
            {
                // If _moveReadPos is true
                readPos += 8; // Increase readPos by 8
            }
            return _value; // Return the long
        }
        else
        {
            throw new Exception("Could not read value of type 'long'!");
        }
    }

    /// <summary>Reads a float from the packet.</summary>
    /// <param name="_moveReadPos">Whether or not to move the buffer's read position.</param>
    public float ReadFloat(bool _moveReadPos = true)
    {
        if (buffer.Count > readPos)
        {
            // If there are unread bytes
            float _value = BitConverter.ToSingle(readableBuffer, readPos); // Convert the bytes to a float
            if (_moveReadPos)
            {
                // If _moveReadPos is true
                readPos += 4; // Increase readPos by 4
            }
            return _value; // Return the float
        }
        else
        {
            throw new Exception("Could not read value of type 'float'!");
        }
    }

    /// <summary>Reads a bool from the packet.</summary>
    /// <param name="_moveReadPos">Whether or not to move the buffer's read position.</param>
    public bool ReadBool(bool _moveReadPos = true)
    {
        if (buffer.Count > readPos)
        {
            // If there are unread bytes
            bool _value = BitConverter.ToBoolean(readableBuffer, readPos); // Convert the bytes to a bool
            if (_moveReadPos)
            {
                // If _moveReadPos is true
                readPos += 1; // Increase readPos by 1
            }
            return _value; // Return the bool
        }
        else
        {
            throw new Exception("Could not read value of type 'bool'!");
        }
    }

    /// <summary>Reads a string from the packet.</summary>
    /// <param name="_moveReadPos">Whether or not to move the buffer's read position.</param>
    public string ReadString(bool _moveReadPos = true)
    {
        try
        {
            int _length = ReadInt(); // Get the length of the string
            string _value = Encoding.ASCII.GetString(readableBuffer, readPos, _length); // Convert the bytes to a string
            if (_moveReadPos && _value.Length > 0)
            {
                // If _moveReadPos is true string is not empty
                readPos += _length; // Increase readPos by the length of the string
            }
            return _value; // Return the string
        }
        catch
        {
            throw new Exception("Could not read value of type 'string'!");
        }
    }

    /// <summary>Reads a Vector2 from the packet.</summary>
    /// <param name="_moveReadPos">Whether or not to move the buffer's read position.</param>
    public Vector2 ReadVector2(bool _moveReadPos = true)
    {
        return new Vector2(ReadFloat(_moveReadPos), ReadFloat(_moveReadPos));
    }
    /// <summary>Reads a Player from the packet.</summary>
    /// <param name="_moveReadPos">Whether or not to move the buffer's read position.</param>
    public Player ReadPlayer(bool _moveReadPos = true)
    {
        int _id = ReadInt(_moveReadPos);
        string _username = ReadString(_moveReadPos);
        PlayerInfo _playerInfo = new PlayerInfo(ReadString(_moveReadPos), ReadString(_moveReadPos),
            ReadString(_moveReadPos), ReadBool(_moveReadPos), ReadBool(_moveReadPos));
        Stats _playerStats = new Stats(ReadInt(_moveReadPos), ReadInt(_moveReadPos),
            ReadInt(_moveReadPos), ReadInt(_moveReadPos), ReadInt(_moveReadPos),
            ReadInt(_moveReadPos), ReadInt(_moveReadPos), ReadInt(_moveReadPos),
            ReadInt(_moveReadPos), ReadInt(_moveReadPos), ReadInt(_moveReadPos),
            ReadInt(_moveReadPos), ReadLong(_moveReadPos), ReadLong(_moveReadPos), ReadInt(_moveReadPos));
        Vector2 _position = ReadVector2(_moveReadPos);
        return new Player(_id, _username, _position, _playerStats, _playerInfo);
    }
    public Item ReadItem(bool _moveReadPos = true)
    {
        return new Item(ReadInt(_moveReadPos), ReadString(_moveReadPos), ReadString(_moveReadPos), ReadInt(_moveReadPos), ReadInt(_moveReadPos), ReadBool(_moveReadPos), ReadString(_moveReadPos));
    }
    public Ammo ReadItemAmmo(bool _moveReadPos = true)
    {
        return new Ammo(ReadInt(_moveReadPos), ReadString(_moveReadPos), ReadString(_moveReadPos), ReadInt(_moveReadPos), ReadInt(_moveReadPos), ReadBool(_moveReadPos), ReadString(_moveReadPos), ReadInt(_moveReadPos), ReadInt(_moveReadPos));
    }
    public Armor ReadItemArmor(bool _moveReadPos = true)
    {
        return new Armor(ReadInt(_moveReadPos), ReadString(_moveReadPos), ReadString(_moveReadPos), ReadInt(_moveReadPos), ReadInt(_moveReadPos), ReadBool(_moveReadPos), ReadString(_moveReadPos), ReadString(_moveReadPos), ReadInt(_moveReadPos), ReadInt(_moveReadPos));
    }
    public Consumable ReadItemConsumable(bool _moveReadPos = true)
    {
        return new Consumable(ReadInt(_moveReadPos), ReadString(_moveReadPos), ReadString(_moveReadPos), ReadInt(_moveReadPos), ReadInt(_moveReadPos), ReadBool(_moveReadPos), ReadString(_moveReadPos), ReadInt(_moveReadPos), ReadInt(_moveReadPos), ReadInt(_moveReadPos), ReadInt(_moveReadPos));
    }
    public Container ReadItemContainer(bool _moveReadPos = true)
    {
        int _id = ReadInt(_moveReadPos);
        string article = ReadString(_moveReadPos);
        string _name = ReadString(_moveReadPos);
        int _imageNumber = ReadInt(_moveReadPos);
        int _weight = ReadInt(_moveReadPos);
        bool _stackable = ReadBool(_moveReadPos);
        string _slotType = ReadString(_moveReadPos);
        int _inventorySlots = ReadInt(_moveReadPos);
        int _price = ReadInt(_moveReadPos);
        List<Ammo> _ammoInInventory = new List<Ammo>();
        List<Armor> _armorsInInventory = new List<Armor>();
        List<Consumable> _consumableInInventory = new List<Consumable>();
        List<Currency> _currencyInInventory = new List<Currency>();
        List<Miscellaneous> _miscInInventory = new List<Miscellaneous>();
        List<Tool> _toolsInInventory = new List<Tool>();
        List<Weapon> _weaponsInInventory = new List<Weapon>();
        List<Container> _containersInInventory = new List<Container>();
        int _ammoCount = ReadInt(_moveReadPos);
        for (int i = 1; i < _ammoCount; i++)
        {
            Ammo ammo = ReadItemAmmo(_moveReadPos);
            _ammoInInventory.Add(ammo);
        }
        int _armorCount = ReadInt(_moveReadPos);
        for (int i = 1; i < _armorCount; i++)
        {
            Armor armor = ReadItemArmor(_moveReadPos);
            _armorsInInventory.Add(armor);
        }
        int _consumableCount = ReadInt(_moveReadPos);
        for (int i = 1; i < _consumableCount; i++)
        {
            Consumable consumable = ReadItemConsumable(_moveReadPos);
            _consumableInInventory.Add(consumable);
        }
        int _containerCount = ReadInt(_moveReadPos);
        for (int i = 1; i < _containerCount; i++)
        {
            Container container = ReadItemContainer(_moveReadPos);
            _containersInInventory.Add(container);
        }
        int _currencyCount = ReadInt(_moveReadPos);
        for (int i = 1; i < _currencyCount; i++)
        {
            Currency currency = ReadItemCurrency(_moveReadPos);
            _currencyInInventory.Add(currency);
        }
        int _miscCount = ReadInt(_moveReadPos);
        for (int i = 1; i < _miscCount; i++)
        {
            Miscellaneous misc = ReadItemMiscellaneous(_moveReadPos);
            _miscInInventory.Add(misc);
        }
        int _toolCount = ReadInt(_moveReadPos);
        for (int i = 1; i < _toolCount; i++)
        {
            Tool tool = ReadItemTool(_moveReadPos);
            _toolsInInventory.Add(tool);
        }
        int _weaponCount = ReadInt(_moveReadPos);
        for (int i = 1; i < _weaponCount; i++)
        {
            Weapon weapon = ReadItemWeapon(_moveReadPos);
            _weaponsInInventory.Add(weapon);
        }
        return new Container(_id, article, _name, _imageNumber, _weight, _stackable, _slotType, _inventorySlots, _price, _ammoInInventory, _armorsInInventory, _consumableInInventory, _currencyInInventory, _miscInInventory, _toolsInInventory, _weaponsInInventory, _containersInInventory);
    }
    public Currency ReadItemCurrency(bool _moveReadPos = true)
    {
        return new Currency(ReadInt(_moveReadPos), ReadString(_moveReadPos), ReadString(_moveReadPos), ReadInt(_moveReadPos), ReadInt(_moveReadPos), ReadBool(_moveReadPos), ReadString(_moveReadPos), ReadInt(_moveReadPos));
    }
    public Miscellaneous ReadItemMiscellaneous(bool _moveReadPos = true)
    {
        return new Miscellaneous(ReadInt(_moveReadPos), ReadString(_moveReadPos), ReadString(_moveReadPos), ReadInt(_moveReadPos), ReadInt(_moveReadPos), ReadBool(_moveReadPos), ReadString(_moveReadPos));
    }
    public Tool ReadItemTool(bool _moveReadPos = true)
    {
        return new Tool(ReadInt(_moveReadPos), ReadString(_moveReadPos), ReadString(_moveReadPos), ReadInt(_moveReadPos), ReadInt(_moveReadPos), ReadBool(_moveReadPos), ReadString(_moveReadPos), ReadString(_moveReadPos), ReadInt(_moveReadPos), ReadInt(_moveReadPos));
    }
    public Weapon ReadItemWeapon(bool _moveReadPos = true)
    {
        return new Weapon(ReadInt(_moveReadPos), ReadString(_moveReadPos), ReadString(_moveReadPos), ReadInt(_moveReadPos), ReadInt(_moveReadPos), ReadBool(_moveReadPos), ReadString(_moveReadPos), ReadString(_moveReadPos), ReadInt(_moveReadPos), ReadBool(_moveReadPos), ReadInt(_moveReadPos));
    }
    #endregion

    private bool disposed = false;

    protected virtual void Dispose(bool _disposing)
    {
        if (!disposed)
        {
            if (_disposing)
            {
                buffer = null;
                readableBuffer = null;
                readPos = 0;
            }

            disposed = true;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}