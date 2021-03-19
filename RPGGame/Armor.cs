using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame
{
    public class Armor
    {
        public string Name { get; set; }
        public double Power { get; set; }
        public Armor(string name, double power)
        {
            this.Name = name;
            this.Power = power;
        }
    }
}
