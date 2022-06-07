using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGLab.RPGLab;
using System.Drawing;
using RPGLab.Entities.Items;
using RPGLab.Entities.Items.ItemTypes;

namespace RPGLab.Networking
{
    public class ClientHandle
    {
        public static Dictionary<int, Player> player = GameManager.players;
        public static Dictionary<int, MonsterManager> monsters = GameManager.monsters;
        public static bool isOnline = false;
        public static void Welcome(Packet _packet)
        {
            string _msg = _packet.ReadString();
            int _myId = _packet.ReadInt();
            //string _mapData = _packet.ReadString();
            //int _mapSize = _packet.ReadInt();

            Console.WriteLine($"Message from server: {_msg}");
            Client.instance.myId = _myId;
            //also send the packet back to server
            ClientSend.WelcomeReceived();
            //Get Map Data
            //string[] LoadFile = _mapData.Split(':');
            //string[,] MainMap = new string[_mapSize, _mapSize];
            //for (int i = 0; i < LoadFile.Length; i++)
            //{
            //    int posY = i / _mapSize;
            //    int posX = i % _mapSize;
            //    MainMap[posY, posX] = LoadFile[i];
            //}
            //TileMap.MainMap = MainMap;
            //TileMap.mapSize = _mapSize;
            TileMap.OnLoad();//Load Maps
            try
            {
                Client.instance.udp.Connect(((IPEndPoint)Client.instance.tcp.socket.Client.LocalEndPoint).Port);
            }
            catch (Exception ex)
            {
                Log.Error($"Error sending connection to server. exception = {ex}");
            }
        }

        public static void CreateAccount(Packet _packet)
        {
            bool _input = _packet.ReadBool();
            AdventuresOnlineWindow.CreateAccountBool(_input);
        }
        public static void WrongAccountorPassword(Packet _packet)
        {
            int _myId = _packet.ReadInt();
            bool _input = _packet.ReadBool();
            int _connectionAttempts = _packet.ReadInt();
            if (Client.instance.myId == _myId)
            {
                Client.instance.ConnectionAttempts = _connectionAttempts;
            }
            AdventuresOnlineWindow.WrongAccountorPassword(_input);
        }
        public static void CreateCharacter(Packet _packet)
        {
            int _myId = _packet.ReadInt();
            bool _input = _packet.ReadBool();
            if (Client.instance.myId == _myId)
            {
                AdventuresOnlineWindow.CreateCharacterBool(_input);
            }
        }

        public static void CharacterSelect(Packet _packet)
        {
            int _myId = _packet.ReadInt();
            string _characters = _packet.ReadString();
            bool _accountExists = _packet.ReadBool();
            if (Client.instance.myId == _myId)
            {
                if (_accountExists)
                {
                    if (_characters != "No Characters")
                    {
                        string[] character = _characters.Split(',');
                        AdventuresOnlineWindow.SendtoCharacterSelectScreen(character);
                    }
                    else
                    {
                        AdventuresOnlineWindow.SendtoCharacterCreateScreen();
                    }
                }
                if (!_accountExists)
                {
                    AdventuresOnlineWindow.WrongAccountorPassword(_accountExists);
                }
            }
        }
        public static void SpawnPlayer(Packet _packet)
        {
            int _clientID = _packet.ReadInt();
            string _username = _packet.ReadString();
            Vector2 _position = _packet.ReadVector2();
            int _playerLevel = _packet.ReadInt();
            string playerAvatar = _packet.ReadString();
            int currentHitPoints = _packet.ReadInt();
            int maxHitPoints = _packet.ReadInt();
            int currentManaPoints = _packet.ReadInt();
            int maxManaPoints = _packet.ReadInt();
            string playerRace = _packet.ReadString();
            string playerClass = _packet.ReadString();
            int playerStrength = _packet.ReadInt();
            int playerDexterity = _packet.ReadInt();
            int playerConstitution = _packet.ReadInt();
            int playerIntellect = _packet.ReadInt();
            int playerWisdom = _packet.ReadInt();
            int playerCharisma = _packet.ReadInt();
            int playerCarryingWeight = _packet.ReadInt();
            int playerExperience = _packet.ReadInt();
            int playerSkillPoints = _packet.ReadInt();
            bool isStealth = _packet.ReadBool();
            int experienceNeeded = _packet.ReadInt();
            int previousExperienceNeeded = _packet.ReadInt();

            List<int> Stats = new List<int>();
            Stats.Add(_playerLevel);
            Stats.Add(currentHitPoints);
            Stats.Add(maxHitPoints);
            Stats.Add(currentManaPoints);
            Stats.Add(maxManaPoints);
            Stats.Add(playerStrength);
            Stats.Add(playerDexterity);
            Stats.Add(playerConstitution);
            Stats.Add(playerIntellect);
            Stats.Add(playerWisdom);
            Stats.Add(playerCharisma);
            Stats.Add(playerCarryingWeight);
            Stats.Add(playerExperience);
            Stats.Add(playerSkillPoints);

            List<string> Info = new List<string>();
            Info.Add(playerAvatar);
            Info.Add(playerRace);
            Info.Add(playerClass);

            Image CharImage = AdventuresOnlineWindow.GetAvatarImage(playerRace, playerAvatar);
            GameManager.SpawnPlayer(_clientID, _username, _position, Stats, Info, CharImage, isStealth, experienceNeeded);
            if (Client.instance.myId == _clientID)
            {
                AdventuresOnlineWindow.loginWindow.SpawnPlayer(_clientID, _username, _position, Stats, Info, isStealth, experienceNeeded, previousExperienceNeeded);
                isOnline = true;
            }
        }
        public static void UpdatePlayer(Packet _packet)
        {
            int _clientID = _packet.ReadInt();
            Vector2 _position = _packet.ReadVector2();
            int _playerLevel = _packet.ReadInt();
            int currentHitPoints = _packet.ReadInt();
            int maxHitPoints = _packet.ReadInt();
            int currentManaPoints = _packet.ReadInt();
            int maxManaPoints = _packet.ReadInt();
            int playerStrength = _packet.ReadInt();
            int playerDexterity = _packet.ReadInt();
            int playerConstitution = _packet.ReadInt();
            int playerIntellect = _packet.ReadInt();
            int playerWisdom = _packet.ReadInt();
            int playerCharisma = _packet.ReadInt();
            int playerCarryingWeight = _packet.ReadInt();
            int playerExperience = _packet.ReadInt();
            int playerSkillPoints = _packet.ReadInt();
            bool isStealth = _packet.ReadBool();
            long experienceRequired = _packet.ReadLong();
            long previousExperienceRequired = _packet.ReadLong();
            if (player.ContainsKey(_clientID))
            {
                player[_clientID].position = _position;
                player[_clientID].sprite.Position = _position;
                player[_clientID].nameTag.Position = _position;
                player[_clientID].level = _playerLevel;
                player[_clientID].currentHitPoints = currentHitPoints;
                player[_clientID].maxHitPoints = maxHitPoints;
                player[_clientID].currentManaPoints = currentManaPoints;
                player[_clientID].maxManaPoints = maxManaPoints;
                player[_clientID].strength = playerStrength;
                player[_clientID].dexterity = playerDexterity;
                player[_clientID].constitution = playerConstitution;
                player[_clientID].intellect = playerIntellect;
                player[_clientID].wisdom = playerWisdom;
                player[_clientID].charisma = playerCharisma;
                player[_clientID].playerCarryingWeight = playerCarryingWeight;
                player[_clientID].playerExperience = playerExperience;
                player[_clientID].playerSkillPoints = playerSkillPoints;
                player[_clientID].isStealth = isStealth;
                player[_clientID].ExperienceRequired = experienceRequired;
                player[_clientID].PreviousExperienceRequired = previousExperienceRequired;

                if (Client.instance.myId == _clientID)
                {
                    AdventuresOnlineWindow.ChaseCamera(player[Client.instance.myId].sprite.Position);
                    AdventuresOnlineWindow.UpdateNameLevelRaceLabel(_clientID);
                }
            }
        }
        public static void PlayerPosition(Packet _packet)
        {
            int _clientID = _packet.ReadInt();
            Vector2 _position = _packet.ReadVector2();
            if (isOnline)
            {
                if (GameManager.players.ContainsKey(_clientID))
                {
                    player[_clientID].position = _position;
                    player[_clientID].sprite.Position = _position;
                    player[_clientID].nameTag.Position = _position;
                    if (_clientID == Client.instance.myId)
                    {
                        AdventuresOnlineWindow.ChaseCamera(player[Client.instance.myId].sprite.Position);
                    }
                }
            }
        }
        public static void MonsterUpdate(Packet _packet)
        {
            bool respawn = _packet.ReadBool();
            string monsterData = _packet.ReadString();
            int damage = _packet.ReadInt();
            int _fromClient = _packet.ReadInt();
            if (player.ContainsKey(_fromClient))
            {
                if (damage != 0)
                {
                    if (!respawn)
                    {
                        if (Client.instance.myId == _fromClient)
                        {
                            AdventuresOnlineWindow.UpdateGameChatBox($"{GameManager.players[_fromClient].username} has slain {monsters[Convert.ToInt32(monsterData)].monsterName} with {damage} damage.");
                        }
                    }
                }
            }
            GameManager.MonsterUpdate(respawn, monsterData);
        }
        public static void UpdateMonsterPosition(Packet _packet)
        {
            int monsterID = _packet.ReadInt();
            Vector2 monsterPos = _packet.ReadVector2();
            if(monsters.ContainsKey(monsterID))
            {
                Collider.colliderArray[(int)monsters[monsterID].position.X, (int)monsters[monsterID].position.Y] = null;
                monsters[monsterID].position = monsterPos;
                Collider.colliderArray[(int)monsterPos.X, (int)monsterPos.Y] = monsters[monsterID].collider;
                monsters[monsterID].collider.Position = monsterPos;
                monsters[monsterID].sprite.Position = monsterPos;
                monsters[monsterID].nameTag.Position = monsterPos;
            }
        }
        public static void PlayerDamageDone(Packet _packet)
        {
            int monsterID = _packet.ReadInt();
            int damage = _packet.ReadInt();
            Vector2 position = _packet.ReadVector2();
            int _fromClient = _packet.ReadInt();
            if (Client.instance.myId == _fromClient)
            {
                if (damage != 0)
                {
                    AdventuresOnlineWindow.UpdateGameChatBox($"{GameManager.players[_fromClient].username} hit {monsters[monsterID].monsterName} for {damage} damage.");
                }
                if(damage == 0)
                {
                    AdventuresOnlineWindow.UpdateGameChatBox($"{GameManager.players[_fromClient].username} missed {monsters[monsterID].monsterName}.");
                }
            }
        }
        public static void MonsterDamageDone(Packet _packet)
        {
            int monsterID = _packet.ReadInt();
            int damage = _packet.ReadInt();
            Vector2 position = _packet.ReadVector2();
            int _toClient = _packet.ReadInt();
            int playerHealth = _packet.ReadInt();
            if (player.ContainsKey(_toClient))
            {
                if (Client.instance.myId == _toClient)
                {
                    GameManager.players[_toClient].currentHitPoints = playerHealth;
                    if (monsters.ContainsKey(monsterID))
                    {
                        if (damage != 0)
                        {
                            AdventuresOnlineWindow.UpdateGameChatBox($"{monsters[monsterID].monsterName} hit {GameManager.players[_toClient].username} for {damage} damage.");
                        }
                        if (damage == 0)
                        {
                            AdventuresOnlineWindow.UpdateGameChatBox($"{monsters[monsterID].monsterName} missed {GameManager.players[_toClient].username}.");
                        }
                    }
                    AdventuresOnlineWindow.UpdateNameLevelRaceLabel(_toClient);
                }
            }
        }
        public static void ChatBox(Packet _packet)
        {
            int _player = _packet.ReadInt();
            string msg = _packet.ReadString();
            AdventuresOnlineWindow.UpdateGameChatBox(msg);
        }
        public static void PopulateMonsters(Packet _packet)
        {
            int _player = _packet.ReadInt();
            string MonsterString = _packet.ReadString();
            string[] Monsters = MonsterString.Split(':');
            foreach(string monster in Monsters)
            {
                string[] monsterData = monster.Split(',');
                if (monsterData.Length > 1 && monsterData[0] != "")
                {
                    int _id = Convert.ToInt32(monsterData[1]);
                    Vector2 position = new Vector2(Convert.ToInt32(monsterData[5]), Convert.ToInt32(monsterData[6]));
                    GameManager.SpawnMonster(_id, monsterData[0], position, monsterData[2]);
                }
            }
        }
        public static void DisconnectPlayer(Packet _packet)
        {
            int _id = _packet.ReadInt();
            player[_id].sprite.DestroySelf();
            player[_id].nameTag.DestroySelf();
            player.Remove(_id);
        }
        public static void DropItemOnGround(Packet _packet)
        {
            string _itemType = _packet.ReadString();
            Vector2 position = _packet.ReadVector2();
            switch (_itemType)
            {
                case "Item":
                    Item _item = _packet.ReadItem();
                    new ItemsAtPosition(_item, position);
                    break;
                case "Ammo":
                    Ammo _ammo = _packet.ReadItemAmmo();
                    _ammo.AmountOfItem = _packet.ReadInt();
                    new ItemsAtPosition(_ammo, position);
                    break;
                case "Armor":
                    Armor _armor = _packet.ReadItemArmor();
                    new ItemsAtPosition(_armor, position);
                    break;
                case "Consumable":
                    Consumable _consumable = _packet.ReadItemConsumable();
                    _consumable.AmountOfItem = _packet.ReadInt();
                    new ItemsAtPosition(_consumable , position);
                    break;
                case "Container":
                    Container _container = _packet.ReadItemContainer();
                    new ItemsAtPosition(_container, position);
                    break;
                case "Currency":
                    Currency _currency = _packet.ReadItemCurrency();
                    _currency.SetAmountOfItem(_packet.ReadInt());
                    new ItemsAtPosition(_currency, position);
                    break;
                case "Miscellaneous":
                    Miscellaneous _miscellaneous = _packet.ReadItemMiscellaneous();
                    _miscellaneous.AmountOfItem = _packet.ReadInt();
                    new ItemsAtPosition(_miscellaneous, position);
                    break;
                case "Tool":
                    Tool _tool = _packet.ReadItemTool();
                    new ItemsAtPosition(_tool, position);
                    break;
                case "Weapon":
                    Weapon _weapon = _packet.ReadItemWeapon();
                    new ItemsAtPosition(_weapon, position);
                    break;
            }
        }
    }
}
