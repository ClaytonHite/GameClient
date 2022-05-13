using RPGLab.Networking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.RPGLab
{
    public class Player
    {
        public Vector2 Position = null;
        public Vector2 spawnPosition;
        public Vector2 currentLocation;
        public string spriteDirectory = "";
        public string Tag = "";
        public string playerRace;
        public string playerClass;
        public string Avatar;
        public int playerStrength;
        public int playerDexterity;
        public int playerConstitution;
        public int playerIntellect;
        public int playerWisdom;
        public int playerCharisma;
        public int playerLevel;
        public string playerAvatar;
        public int currentHitPoints;
        public int maxHitPoints;
        public int currentManaPoints;
        public int maxManaPoints;
        public bool isMoving = false;
        public int id;
        public string username;
        public string Name = "";
        public string Race = "";
        public string Class = "";
        public bool playerBusy = false;

        public Player(int _myId, string _username, Vector2 _position, List<int> _characterStats, List<string> _characterInfo)
        {
            id = _myId;
            username = _username;
            playerStrength = _characterStats[5];
            playerDexterity = _characterStats[6];
            playerConstitution = _characterStats[7];
            playerIntellect = _characterStats[8];
            playerWisdom = _characterStats[9];
            playerCharisma = _characterStats[10];
            playerLevel = _characterStats[0];
            playerAvatar = _characterInfo[0];
            playerRace = _characterInfo[1];
            playerClass = _characterInfo[2];
            currentHitPoints = _characterStats[1];
            maxHitPoints = _characterStats[2];
            currentManaPoints = _characterStats[3];
            maxManaPoints = _characterStats[4];
            Vector2 currentLocation = _position;
            this.Name = _username;
            this.Avatar = playerAvatar;
            this.Race = playerRace;
            this.Class = playerClass;
            this.Position = currentLocation;
            this.playerBusy = false;
            AdventuresOnlineWindow.PlayerData(this);
        }
    }
}
