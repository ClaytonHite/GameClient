using RPGLab.RPGLab;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

public class PlayerManager
{
    public int id;
    public string username;
    public string playerAvatar;
    public string playerRace;
    public string playerClass;
    public Vector2 position;
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
    public Sprite2D sprite;
    public NameTag2D nameTag;
    public bool playerBusy;
    public int playerCarryingWeight;
    public int playerExperience;
    public int playerSkillPoints;
    public bool isStealth;
    public long ExperienceRequired;
    public long PreviousExperienceRequired;
}
