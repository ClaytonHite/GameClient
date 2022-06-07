using RPGLab.Entities.Items;
using RPGLab.Networking;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.RPGLab
{
    public class Player
    {
        public int id;
        public string username;
        public string playerAvatar;
        public string playerRace;
        public string playerClass;
        public Vector2 position;
        public Vector2 spawnPosition;
        public int level;
        public int currentHitPoints;
        public int maxHitPoints;
        public int currentManaPoints;
        public int maxManaPoints;
        public int strength;
        public int dexterity;
        public int constitution;
        public int intellect;
        public int wisdom;
        public int charisma;
        public Sprite2D sprite = null;
        public NameTag2D nameTag = null;
        public bool playerBusy;
        public bool isMoving = false;
        public int playerCarryingWeight;
        public int playerExperience;
        public int playerSkillPoints;
        public bool isStealth;
        public long ExperienceRequired;
        public long PreviousExperienceRequired;
        public string Tag = "";

        public Player(int _id, string _username, Vector2 _position, List<int> Stats, List<string> Info, Image CharImage, bool Stealth, int experienceNeeded)
        {
            id = _id;
            username = _username;
            strength = Stats[5];
            dexterity = Stats[6];
            constitution = Stats[7];
            intellect = Stats[8];
            wisdom = Stats[9];
            charisma = Stats[10];
            level = Stats[0];
            playerAvatar = Info[0];
            playerRace = Info[1];
            playerClass = Info[2];
            currentHitPoints = Stats[1];
            maxHitPoints = Stats[2];
            currentManaPoints = Stats[3];
            maxManaPoints = Stats[4];
            playerCarryingWeight = Stats[11];
            playerExperience = Stats[12];
            ExperienceRequired = experienceNeeded;
            playerSkillPoints = Stats[13];
            isStealth = Stealth;
            position = _position;
            playerBusy = false;
            nameTag = new NameTag2D(_position, new Vector2(96, 64), _username, "Player");
            sprite = new Sprite2D(_position, new Vector2(96, 64), CharImage, "Player");
        }
    }
}
