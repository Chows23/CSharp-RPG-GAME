using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame
{
    public class Game
    {
        public Hero Hero { get; set; }
        public Fight Fight { get; set; }
        public static int gameplay = 0;

        public Game(Hero hero, Fight fight)
        {
            this.Hero = hero;
            this.Fight = fight;
        }

        public void Start()
        {
            string name = this.GetName();
            string choice = string.Empty;
            do
            {
                this.FollowingOptions();
                do
                {
                    Console.WriteLine($"Hi {name}, do you want to show option again - YES or NO?");
                    choice = Console.ReadLine().ToUpper();
                } 
                while (choice != "NO" && choice != "YES");
            }
            while (choice == "YES");
        }

        public string GetName()
        {
            string input;
            int number;
            do
            {
                Console.WriteLine("What is your name:");
                input = Console.ReadLine();
            } 
            while (string.IsNullOrEmpty(input) || int.TryParse(input, out number));

            return input;
        }

        public void FollowingOptions()
        {
            Console.WriteLine("The following options: Please enter number between 1 and 3");
            Console.WriteLine("1. Show statistics, 2. Show inventory, 3. Fight the random monster, 4. Fight the strongest monster");
            
            string choice = string.Empty;
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine($"Number of games we played so far: {gameplay}\nNumber of games we won so far: {Fight.gameWon}\nNumber of games we lose so far: {Fight.gameLose}\nCoin: ${Fight.coin}");
            }
            if (choice == "2")
            {
                this.Hero.ShowInventory();
            }
            if (choice == "3")
            {
                this.Fight.StartFight();
                gameplay++;
            }
            if (choice == "4")
            {
                this.Fight.StartFightTop();
                gameplay++;
            }
        }

    }
}
