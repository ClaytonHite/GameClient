using RPGLab.Networking;
using RPGLab.RPGLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.Combat
{
    class Combat
    {
        public static bool attackLeft;
        public static bool attackRight;
        public static bool attackUp;
        public static bool attackDown;
        public static bool attackUpLeft;
        public static bool attackUpRight;
        public static bool attackDownLeft;
        public static bool attackDownRight;
        public static Dictionary<int, Player> player = GameManager.players;
        public static Dictionary<int, MonsterManager> monsters = GameManager.monsters;
        static int playerRange = 6;
        public static void Update()
        {
            if (player.ContainsKey(Client.instance.myId))
            {
                if (!player[Client.instance.myId].playerBusy)
                {
                    Vector2 playerPos = player[Client.instance.myId].position;
                    foreach (KeyValuePair<int, MonsterManager> monster in monsters)
                    {
                        if ((playerPos.X - monster.Value.position.X) <= playerRange && (playerPos.X - monster.Value.position.X) >= (-1) * playerRange &&
                            (playerPos.Y - monster.Value.position.Y) <= playerRange && (playerPos.Y - monster.Value.position.Y) >= (-1) * playerRange)
                        {
                            if (attackUp)
                            {
                                if (monster.Value.position.X == playerPos.X && monster.Value.position.Y == playerPos.Y - 1f)
                                {
                                    ClientSend.PlayerCombat(monster.Key, monster.Value.position);
                                }
                            }
                            else if (attackDown)
                            {
                                if (monster.Value.position.X == playerPos.X && monster.Value.position.Y == playerPos.Y + 1f)
                                {
                                    ClientSend.PlayerCombat(monster.Key, monster.Value.position);
                                }
                            }
                            else if (attackLeft)
                            {
                                if (monster.Value.position.X == playerPos.X - 1f && monster.Value.position.Y == playerPos.Y)
                                {
                                    ClientSend.PlayerCombat(monster.Key, monster.Value.position);
                                }
                            }
                            else if (attackRight)
                            {
                                if (monster.Value.position.X == playerPos.X + 1f && monster.Value.position.Y == playerPos.Y)
                                {
                                    ClientSend.PlayerCombat(monster.Key, monster.Value.position);
                                }
                            }
                            else if (attackUpLeft)
                            {
                                if (monster.Value.position.X == playerPos.X - 1f && monster.Value.position.Y == playerPos.Y - 1f)
                                {
                                    ClientSend.PlayerCombat(monster.Key, monster.Value.position);
                                }
                            }
                            else if (attackUpRight)
                            {
                                if (monster.Value.position.X == playerPos.X + 1f && monster.Value.position.Y == playerPos.Y - 1f)
                                {
                                    ClientSend.PlayerCombat(monster.Key, monster.Value.position);
                                }
                            }
                            else if (attackDownLeft)
                            {
                                if (monster.Value.position.X == playerPos.X - 1f && monster.Value.position.Y == playerPos.Y + 1f)
                                {
                                    ClientSend.PlayerCombat(monster.Key, monster.Value.position);
                                }
                            }
                            else if (attackDownRight)
                            {
                                if (monster.Value.position.X == playerPos.X + 1f && monster.Value.position.Y == playerPos.Y + 1f)
                                {
                                    ClientSend.PlayerCombat(monster.Key, monster.Value.position);
                                }
                            }
                        }
                    }
                }
            }
        }        
    }
}
