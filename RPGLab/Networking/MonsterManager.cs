using RPGLab.RPGLab;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

public class MonsterManager
{
    public int id;
    public string monsterName;
    public string monsterAvatar;
    public string monsterRace;
    public string monsterClass;
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
    public Collider collider;
}
