using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame
{
    public class Fight
    {
        public List<Monster> Monsters { get; set; }
        public Hero Hero { get; set; }
        public static int gameWon = 0;
        public static int gameLose = 0;
        public static int coin = 10;

        public Fight(Hero hero, List<Monster> monsters)
        {
            this.Hero = hero;
            this.Monsters = monsters;
        }

        public void StartFight()
        {
            Font();
            Random rnd = new Random();
            var monster = this.Monsters[rnd.Next(Monsters.Count)];

            while (true)
            {
                if (HeroTurn(this.Hero, monster) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (MonsterTurn(monster, this.Hero) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        public void StartFightTop()
        {
            double strengest = 0;
            Monster monster = null;
            foreach (var mons in this.Monsters)
            {
                if (mons.Strength > strengest)
                {
                    strengest = mons.Strength;
                    monster = mons;
                }
            }
            Console.WriteLine($"Start fight the strongest monster {monster.Name}");

            while (true)
            {
                if (HeroTurn(this.Hero, monster) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (MonsterTurn(monster, this.Hero) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        public string HeroTurn(Hero hero, Monster monster)
        {
            double heroAttack = this.Hero.Attack();
            double monsterDefense = monster.Defense;

            double dmgToMonster = heroAttack - monsterDefense;

            if (dmgToMonster > 0)
            {
                monster.CurrentHealth = monster.CurrentHealth - dmgToMonster;
            }
            else dmgToMonster = 0;

            Console.WriteLine("{0} Attacks {1} and {0} attackValue:{3}, {1} blockValue:{4} cause {2} Damage",
                this.Hero.Name,
                monster.Name,
                dmgToMonster,
                heroAttack,
                monsterDefense);

            if (monster.CurrentHealth < 0)
                monster.CurrentHealth = 0;

            Console.WriteLine($"{monster.Name} Has {monster.CurrentHealth} Health left\n");

            if (monster.CurrentHealth <= 0)
            {
                Console.WriteLine($"{this.Hero.Name} won and earn $50, {monster.Name} has Died\n");

                gameWon++;
                coin += 50;
                ResetHealth(monster, hero);
                return "Game Over";
            }
            else
            {
                Console.WriteLine("Press any key to continue monster turn");
                Console.ReadKey();
                return "continue";
            }

        }

        public string MonsterTurn(Monster monster, Hero hero)
        {
            double monsterAttack = monster.Strength;
            double heroDefense = hero.Block();

            double dmgToHero = monsterAttack - heroDefense;

            if (dmgToHero > 0)
            {
                hero.CurrentHealth = hero.CurrentHealth - dmgToHero;
            }
            else dmgToHero = 0;

            Console.WriteLine("{0} Attacks {1} and {0} attackValue:{3}, {1} blockValue:{4} cause {2} Damage",
                monster.Name,
                hero.Name,
                dmgToHero,
                monsterAttack,
                heroDefense);

            if (hero.CurrentHealth < 0)
                hero.CurrentHealth = 0;

            Console.WriteLine($"{hero.Name} Has {hero.CurrentHealth} Health left\n");

            if (hero.CurrentHealth <= 0)
            {
                Console.WriteLine($"{hero.Name} has Died and {monster.Name} won\n");

                gameLose++;
                ResetHealth(monster, hero);
                return "Game Over";
            }
            else
            {
                Console.WriteLine("Press any key to continue hero turn");
                Console.ReadKey();
                HealHealth(hero);

                return "continue";
            }

        }

        public void ResetHealth(Monster monster, Hero hero)
        {
            hero.CurrentHealth = hero.OriginalHealth;
            monster.CurrentHealth = monster.OriginalHealth;
        }

        public void HealHealth(Hero hero)
        {
            Console.WriteLine("Do u wanna heal - YES or NO?");
            string choice = string.Empty;
            do
            {
                choice = Console.ReadLine().ToUpper();

                if(choice != "NO" && choice != "YES")
                    Console.WriteLine("Do u wanna heal - YES or NO?");

                if (choice == "YES")
                {
                    if(coin >= 10)
                    {
                        coin -= 10;
                        hero.CurrentHealth += 30;
                        Console.WriteLine($"Current heath: {hero.CurrentHealth}, it cost $10 coin.");
                    }
                    else
                        Console.WriteLine("Not enough coin");
                }
            }
            while (choice != "NO" && choice != "YES");

        }

        public void Font()  //ASCII Text Generator
        {
            Console.WriteLine(@" ________  _________  ________  ________  _________        ________ ___  ________  ___  ___  _________   ");
            Console.WriteLine(@"|\   ____\|\___   ___|\   __  \|\   __  \|\___   ___\     |\  _____|\  \|\   ____\|\  \|\  \|\___   ___\ ");
            Console.WriteLine(@"\ \  \___|\|___ \  \_\ \  \|\  \ \  \|\  \|___ \  \_|     \ \  \__/\ \  \ \  \___|\ \  \\\  \|___ \  \_| ");
            Console.WriteLine(@" \ \_____  \   \ \  \ \ \   __  \ \   _  _\   \ \  \       \ \   __\\ \  \ \  \  __\ \   __  \   \ \  \  ");
            Console.WriteLine(@"  \|____|\  \   \ \  \ \ \  \ \  \ \  \\  \|   \ \  \       \ \  \_| \ \  \ \  \|\  \ \  \ \  \   \ \  \");
            Console.WriteLine(@"    ____\_\  \   \ \__\ \ \__\ \__\ \__\\ _\    \ \__\       \ \__\   \ \__\ \_______\ \__\ \__\   \ \__\");
            Console.WriteLine(@"   |\_________\   \|__|  \|__|\|__|\|__|\|__|    \|__|        \|__|    \|__|\|_______|\|__|\|__|    \|__|");
            Console.WriteLine(@"   \|_________|    ");
            Console.WriteLine();
        }
    }
}
