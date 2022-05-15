using RPGLab.RPGLab;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using RPGLab;
using RPGLab.Networking;
using System.Windows.Forms;
using System;

namespace RPGLab
{
    class GameManager : AdventuresOnline
    {
        //SINGLETON public static GameManager instance;
        public static Dictionary<int, PlayerManager> players = new Dictionary<int, PlayerManager>();
        public static Dictionary<int, PlayerManager> playerInfo = new Dictionary<int, PlayerManager>();
        public static Dictionary<int, PlayerManager> playerStats = new Dictionary<int, PlayerManager>();
        public static Dictionary<int, PlayerManager> onlinePlayers = new Dictionary<int, PlayerManager>();
        public static Dictionary<int, MonsterManager> monsters = new Dictionary<int, MonsterManager>();
        public static Dictionary<int, Collider> Colliders = Collider.Colliders;
        public static PlayerManager _player = new PlayerManager();

        public static void SpawnPlayer(int _id, string _username, Vector2 _position, List<int> Stats, List<string> Info, Image CharImage, bool isStealth, int experienceNeeded)
        {
            if (players.ContainsKey(_id))
            {
                if (players[_id].username != _username)
                {
                    players.Remove(_id);
                }
            }
            if (_id == Client.instance.myId)
            {
                if (!players.ContainsKey(_id))
                {
                    _player.sprite = new Sprite2D(_position, new Vector2(96, 64), CharImage, "Player");
                    AdventuresOnlineWindow.ChaseCamera(_position);
                    _player.nameTag = new NameTag2D(_position, new Vector2(96, 64), _username, "Player");
                }
            }
            else
            {
                if (!players.ContainsKey(_id))
                {
                    _player.sprite = new Sprite2D(_position, new Vector2(96, 64), CharImage, "Player");
                    _player.nameTag = new NameTag2D(_position, new Vector2(96, 64), _username, "Player");
                }
            }
            _player.id = _id;
            _player.username = _username;
            _player.position = _position;
            _player.level = Stats[0];
            _player.currentHitPoints = Stats[1];
            _player.maxHitPoints = Stats[2];
            _player.currentManaPoints = Stats[3];
            _player.maxManaPoints = Stats[4];
            _player.strength = Stats[5];
            _player.dexterity = Stats[6];
            _player.constitution = Stats[7];
            _player.intellect = Stats[8];
            _player.wisdom = Stats[9];
            _player.charisma = Stats[10];
            _player.playerAvatar = Info[0];
            _player.playerRace = Info[1];
            _player.playerClass = Info[2];
            _player.playerCarryingWeight = Stats[11];
            _player.playerExperience = Stats[12];
            _player.playerSkillPoints = Stats[13];
            _player.isStealth = isStealth;
            _player.playerBusy = false;
            _player.ExperienceRequired = experienceNeeded;
            Log.Info($"Registering client {_id}");
            if (!players.ContainsKey(_id))
            {
                players.Add(_id, _player);
            }
            players[_id].nameTag.Position = _position;
        }
        public static void SpawnMonster(int _id, string monsterName, Vector2 _position, string CharImage)
        {
            MonsterManager _monster = new MonsterManager();
            if (monsters.ContainsKey(_id))
            {
                if (monsters[_id].monsterName != monsterName)
                {
                    monsters.Remove(_id);
                }
            }
            if (!monsters.ContainsKey(_id))
            {
                _monster.id = _id;
                _monster.monsterName = monsterName;
                _monster.position = _position;
                _monster.sprite = new Sprite2D(_position, new Vector2(96, 64), (Image)Properties.Resources.ResourceManager.GetObject("_" + CharImage), "Monster");
                _monster.nameTag = new NameTag2D(_position, new Vector2(96, 64), monsterName, "Monster");
                _monster.collider = new Collider(_position, false);
                monsters.Add(_id, _monster);
            }
        }
        public static void MonsterUpdate(bool respawn, string MonsterData)
        {
            string[] monsterData = MonsterData.Split(',');
            if (respawn)
            {
                SpawnMonster(Convert.ToInt32(monsterData[1]), monsterData[0], new Vector2(Convert.ToInt32(monsterData[5]), Convert.ToInt32(monsterData[6])), monsterData[2]);
            }
            if (!respawn)
            {
                try
                {
                    List<Sprite2D> RemovalList = new List<Sprite2D>();
                    List<NameTag2D> NameRemovalList = new List<NameTag2D>();
                    int monsterID = Convert.ToInt32(MonsterData);
                    Vector2 monsterPos = monsters[monsterID].position;
                    Image monsterImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + monsters[monsterID].monsterAvatar);
                    string monsterName = monsters[monsterID].monsterName;
                    foreach (Sprite2D sprite in Sprite2D.GetSprites())
                    {
                        if (sprite.Tag == "Monster" && sprite.Position.X == monsterPos.X && sprite.Position.Y == monsterPos.Y)
                        {
                            RemovalList.Add(sprite);
                        }
                    }
                    foreach (NameTag2D nameTag in NameTag2D.GetNameTags())
                    {
                        if (nameTag.Tag == "Monster" && nameTag.Position.X == monsterPos.X && nameTag.Position.Y == monsterPos.Y && nameTag.PlayerName == monsterName)
                        {
                            NameRemovalList.Add(nameTag);
                        }
                    }
                    Collider.DestorySelf(monsterPos);
                    foreach (Sprite2D sprite in RemovalList)
                    {
                        sprite.DestroySelf();
                    }
                    foreach (NameTag2D nameTag in NameRemovalList)
                    {
                        nameTag.DestroySelf();
                    }
                    monsters.Remove(monsterID);
                }
                catch
                {
                    Console.WriteLine("DEBUG THIS TOO");
                }
            }
        }
        public override void OnLoad()
        {
            players = new Dictionary<int, PlayerManager>();
            playerInfo = new Dictionary<int, PlayerManager>();
            playerStats = new Dictionary<int, PlayerManager>();
            onlinePlayers = new Dictionary<int, PlayerManager>();
            monsters = new Dictionary<int, MonsterManager>();
        }
        public override void OnUpdate()
        {
        }

        public override void OnDraw()
        {
        }

        public override void GetKeyDown(KeyEventArgs e)
        {
        }

        public override void GetKeyUp(KeyEventArgs e)
        {
        }
    }
}
