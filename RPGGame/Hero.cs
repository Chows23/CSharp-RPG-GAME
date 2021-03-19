using PowerArgs.Games;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame
{
    public class Hero
    {
        public string Name { get; set; }
        public double Strength { get; set; }
        public double Defense { get; set; }
        public double OriginalHealth { get; set; }
        public double CurrentHealth { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public Armor EquippedArmor { get; set; }
        public List<Armor> ArmorsBag { get; set; }
        public List<Weapon> WeaponsBag { get; set; }

        public Hero(string name, double strength, double defense, double health, double currentHealth)
        {
            this.Name = name;
            this.Strength = strength;
            this.Defense = defense;
            this.OriginalHealth = health;
            this.CurrentHealth = currentHealth;

            this.EquippedWeapon = new Weapon("", 0);
            this.WeaponsBag = new List<Weapon>();

            this.EquippedArmor = new Armor("", 0);
            this.ArmorsBag = new List<Armor>();
        }
        
        public double Attack()
        {
            return this.Strength + this.EquippedWeapon.Power;
        }

        public void EquipWeapon(Weapon weapon)
        {
            this.EquippedWeapon = weapon;
            WeaponsBag.Add(weapon);
        }

        
        public double Block()
        {
            return this.Defense + this.EquippedArmor.Power;
        }

        public void EquipArmor(Armor armor)
        {
            this.EquippedArmor = armor;
            ArmorsBag.Add(armor);
        }


        public void ShowInventory()
        {
            Console.WriteLine("Current weapons you have:");
            foreach (var weapon in this.WeaponsBag)
                Console.WriteLine(weapon.Name);

            Console.WriteLine("Current armors you have:");
            foreach (var armor in this.ArmorsBag)
                Console.WriteLine(armor.Name);
        }

    }
}
