using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame
{
    public class Monster
    {
        public string Name { get; set; }
        public double Strength { get; set; }
        public double Defense { get; set; }
        public double OriginalHealth { get; set; }
        public double CurrentHealth { get; set; }

        public Monster(string name, double strength, double defense, double originalHealth, double currentHealth)
        {
            this.Name = name;
            this.Strength = strength;
            this.Defense = defense;
            this.OriginalHealth = originalHealth;
            this.CurrentHealth = currentHealth;
        }

    }
}
