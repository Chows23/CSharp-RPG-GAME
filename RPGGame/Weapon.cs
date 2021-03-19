using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame
{
    public class Weapon
    {
        public string Name { get; set; }
        public double Power { get; set; }
        public Weapon(string name, double power)
        {
            this.Name = name;
            this.Power = power;
        }

    }
}
