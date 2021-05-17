# C#, OOP RPG-GAME

We want to create an RPG game, like those games where you are a hero and you are fighting monsters.
The game will start with asking about our name, then it will present us with the following options:
- `Show our statistics` (like number of games we played so far, number of games we won so
far…etc)
- `Show our inventory` (like what weapons and armors we currently have)
- `Fight!` (it will start a fighting game between us and a random monster from a list of monsters)
The game has the following classes:
- `Hero`, which represents us (the player), the hero has the following properties:
o Name
o Base Strength (will be added to the weapon’s strength to calculate attacks damage)
o Base Defense (will be added to the armor’s defense to calculate the defense against each attack)
o OriginalHealth (Hit Points)
o CurrentHealth
o EquippedWeapon
o EquippedArmor
o ArmorsBag
o WeaponsBag
And the following functions:
o Show Stats
o Show Inventory
o Equip Weapon
o Equip Armor
- `Monster`, which has the following properties:
o Name
o Strength
o Defense
o OriginalHealth
o CurrentHealth
- `Weapon` and `Armo`r classes, both have a Name and a power property
- `Fight` class, this class is responsible for organizing the fight, so there should be a function for the
hero turn, monster turn, Win and Lose functions, of course you win if the monster died, and you
lose if you died first(your Health == 0)
o The attack damage of the user is (User Strength + Equipped weapon strength)
o The Defense property means how much HP you can block with EACH received attack
o The Defense of the user is (User Defense + Equipped Armor defense)
- `Game` class, it will show the main menu for us, and it will have a proper function call for each
option in the main menu (switch statement), once you finish an option (like showing your stats),
you should be able to go back to the main menu without restarting the application.
- Inside the main function (class Program), we just want to create an object (game) from Game
class, then call game.Start().

Notes:
- You can add any suitable properties and helper functions that you think are important to the
solution.
Bonus functions:
- The user can choose to fight the strongest (top damage or top defense) monster
- A Hero can earn coins if he won a match, he can use those coins to buy Health during the game.
