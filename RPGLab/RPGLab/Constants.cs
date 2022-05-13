using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.RPGLab
{
    class Constants
    {
        public const int TICKS_PER_SEC = 30;
        public const int MS_PER_TICK = 1000 / TICKS_PER_SEC;
        public static string[] Races = { "Dragonborn", "Dwarf", "Elf", "Gnome", "Goblin", "Half-Elf", "Halfling", "Human" };
        public static string[] ExpandedRaces = { "Orc", "Troll", "Undead" };
        public static string[] Classes = { "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard" };
        public static string[] Stats = { "Strength", "Dexterity", "Constitution", "Intellect", "Wisdom", "Charisma" };
    }
}
