using System;
using System.Collections.Generic;

namespace RPGGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var chows23 = new Hero("Chows", 99, 80, 100, 100);

            var dragon33 = new Monster("dragon1", 88, 66, 100, 100);
            var dragon66 = new Monster("dragon2", 84, 82, 100, 100);
            var dragon67 = new Monster("dragon3", 100, 90, 100, 100);
            var dragon68 = new Monster("dragon4", 110, 80, 100, 100);
            var monsterList = new List<Monster>() { dragon33, dragon66, dragon67, dragon68 };


            var sword = new Weapon("Long Sword", 1);
            var gun = new Weapon("Big Gun", 2);
            var helmet = new Armor("Helmet", 3);


            chows23.EquipWeapon(sword);
            chows23.EquipWeapon(gun);
            chows23.EquipArmor(helmet);


            var fight = new Fight(chows23, monsterList);
            var game = new Game(chows23, fight);
            game.Start();

        }
    }
}
