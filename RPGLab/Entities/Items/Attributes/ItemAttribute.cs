﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.Entities.Items.Attributes
{
    public class ItemAttribute
    {
        public string[] magicalAttribute = { "Assassin's", "Banishing", "Frenzied", "Celestial", "Divine", "Flaming", "Frozen", "Precise", "Reliable", "Shadowed", "Sharp", "Shocking", "Vengeful" };
        public string[] materialAttribute = { "Adamantine", "Alder", "Ash", "Bone", "Bronze", "Bronzewood", "Copper", "Golden", "Iron", "Mithril", "Oak", "Stone", "Wooden", "Yew" };
        public string MagicalAttributeString;
        public string MaterialAttributeString;
        public int ArmorAttribute;
        public int WeaponAttribute;
        public ItemAttribute(string magic, string material, int armor, int weapon)
        {
            this.MagicalAttributeString = magic;
            this.MaterialAttributeString = material;
            this.ArmorAttribute = armor;
            this.WeaponAttribute = weapon;
        }
    }
}
