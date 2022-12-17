﻿using RPGLab.RPGLab;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using RPGLab;
using RPGLab.Networking;
using System.Windows.Forms;
using System;
using RPGLab.Entities.Players;

namespace RPGLab
{
    class GameManager : AdventuresOnline
    {
        //SINGLETON public static GameManager instance;
        public static Dictionary<int, Player> players = new Dictionary<int, Player>();
        public static Dictionary<int, PlayerManager> playerInfo = new Dictionary<int, PlayerManager>();
        public static Dictionary<int, PlayerManager> playerStats = new Dictionary<int, PlayerManager>();
        public static Dictionary<int, PlayerManager> onlinePlayers = new Dictionary<int, PlayerManager>();
        public static Dictionary<int, MonsterManager> monsters = new Dictionary<int, MonsterManager>();
        public static PlayerManager _player = new PlayerManager();

        public static void SpawnPlayer(Player _player)
        {
            Log.Info($"Registering client {_player.id}");
            if(players.ContainsKey(_player.id))
            {
                players.Remove(_player.id);
            }//Make Disconnect function to remove player from dictionary, sprite, nametag, and collider
            players.Add(_player.id, _player);
            if(Client.instance.myId == _player.id)
            {
                AdventuresOnlineWindow.ChaseCamera(_player.position);
            }
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
                _monster.collider = new Collider(_position, false, "Monster");
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
                int monsterID = Convert.ToInt32(MonsterData);
                if (monsters.ContainsKey(monsterID))
                {
                    List<Sprite2D> RemovalList = new List<Sprite2D>();
                    List<NameTag2D> NameRemovalList = new List<NameTag2D>();
                    Vector2 monsterPos = monsters[monsterID].position;
                    Image monsterImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + monsters[monsterID].monsterAvatar);
                    string monsterName = monsters[monsterID].monsterName;
                    monsters[monsterID].sprite.DestroySelf();
                    monsters[monsterID].nameTag.DestroySelf();
                    monsters[monsterID].collider.DestroySelf();
                    monsters.Remove(monsterID);
                }
            }
        }
        public override void OnLoad()
        {
            players = new Dictionary<int, Player>();
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
