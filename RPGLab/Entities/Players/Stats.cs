using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.Entities.Players
{

    public class Stats
    {
        public int strength;
        public int dexterity;
        public int constitution;
        public int intellect;
        public int wisdom;
        public int charisma;
        public int level;
        public int currentHitPoints;
        public int maxHitPoints;
        public int currentManaPoints;
        public int maxManaPoints;
        public int playerCarryingWeight;
        public long playerExperience;
        public long ExperienceRequired;
        public int playerSkillPoints;
        public Stats(int strength, int dexterity, int constitution,
            int intellect, int wisdom, int charisma, int level, int currentHitPoints,
            int maxHitPoints, int currentManaPoints, int maxManaPoints,
            int playerCarryingWeight, long playerExperience, long experienceRequired, int playerSkillPoints)
        {
            this.strength = strength;
            this.dexterity = dexterity;
            this.constitution = constitution;
            this.intellect = intellect;
            this.wisdom = wisdom;
            this.charisma = charisma;
            this.level = level;
            this.currentHitPoints = currentHitPoints;
            this.maxHitPoints = maxHitPoints;
            this.currentManaPoints = currentManaPoints;
            this.maxManaPoints = maxManaPoints;
            this.playerCarryingWeight = playerCarryingWeight;
            this.playerExperience = playerExperience;
            this.ExperienceRequired = experienceRequired;
            this.playerSkillPoints = playerSkillPoints;
        }

        public void SetHealth( int _health)
        {
            this.currentHitPoints = _health;
        }
    }
}
