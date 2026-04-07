# Elemental Quest

Group Members :

1. Muhammad Danish Irfan bin Nasimussobah
2. Muhammad Izzudin bin Bakar
3. Luqmanul Hakim bin Ahmad Azizi
4. Hariz Hakimi bin Jasri
5. Mohammad Nazri Aizad bin Mohammad Nazroel
6. ⁠Izzryl Hafizzy bin Azrui Nizam


Project description :

Elemental Quest features a turn-based combat system where players can attack using elemental based skills, switch element or use potions from their inventory. There are 3 elements which are Fire, Water, and Grass. The logic is simple, Fire can burn Grass, Water can extinguish Fire, while Grass can absorb Water. This is what makes the battle balance. Also, potions provide healing and temporary damage boost. Thus, an inventory system is implemented to manage potions. Besides, a shop system is developed to allows players to purchase additional potions using gold earned from winning battles. After each victory, players receive rewards such as gold or items that can be used to prepare for next battle. 

The goal of this game is to defeat the enemy by reducing their health points (HP) to zero. Before each battle, the player selects an element while the enemy’s element remains hidden until the fight begins. During combat, the player may have the disadvantage if the element selected is weaker against enemy’s element, therefore the player is allowed to switch elements to gain advantage. However, this action consumes one turn. Both the player and the enemy have levels that affect their health and damage output. Hence, making the gameplay increasingly difficult.

System Features :

1. Character class (base combat system)
- This class acts as the base class for all combat entities and it contains shared attributes such as healthpoint, damage and element. It also has core combat methods like Attack() that can be used by all combat entities. This is done to ensure all characters follow a standard combat structure.

2. Player class (player management)
- This class is inherited by the base class Character and it represents the user-controlled character in the program. Specific to this class, it adds gold system, inventory system and the usage of special skill which allows the interaction with other classes such as Shop, Inventory and Battle. The player can also switch their element in the middle of the battle which is a mechanic specific to only the Player Class. This class also handles player progression and the decisions made by the user.

3. Enemy class & EnemyBoss class (enemy customization)
- The enemy in the program is divided into two categories which are the standard enemy and the boss enemy. The standard enemy only uses standard combat behaviour which is available in the Character Class. On the other hand, the boss enemy is different as it has a phase system added to give the player a more challenging experience when fighting the boss and it takes 20% less damage compared to the standard enemy. By killing the enemy, the player will be rewarded with a certain amount of gold. In short, these classes provide challenge variation and difficulty scaling in the program.

4. Menu class (game navigation system)
- This class acts as a navigation controller of the program to the player. It displays the selection of the system that the player can choose to navigate. This includes the level selection, shop and inventory system.

5. Shop class (item purchasing system)
- This class supports the economy system in the game where the player can use their collected golds to purchase potions that will give them advantage in the battle. It handles the displays of the purchasable items and the buying logic and gold deductions that occur when the player has purchased items.

6. Inventory & potion class (item storage & usage)
- These two classes act as the resource management system in the program. The Inventory class is responsible to store the player items in this case are potions and allow the usage of the said items. The potions in the game have special effects that can heal the player or give shield that will block the enemy incoming attack for a certain number of turns.

7. Game class (program entry point)
- This class is the main entry point of the program. It handles the story introduction of the game to the player, the beginning of the player creation where the user need to give a name to their character and the starting of the main menu. 

8. Element class
- This class manages the three different element types which are fire, water and grass that are associated with the combat character. It also controls the element selection mechanism in the Player Class and adds a damage multiplier in the damage calculation in consideration with the element matchup. For effective element matchup such as fire against grass, a 2x damage multiplier will be added into the calculation while a 0.5x multiplier will be added when not effective element matchup occurs like fire against water and the same element matchup will result to a 1x damage multiplier in the damage calculation. In short this class adds strategy to the combat mechanism similar to other RPGs like Pokémon.

9. Battle class
- This class manages the three different element types which are fire, water and grass that are associated with the combat character. It also controls the element selection mechanism in the Player Class and adds a damage multiplier in the damage calculation in consideration with the element matchup. For effective element matchup such as fire against grass, a 2x damage multiplier will be added into the calculation while a 0.5x multiplier will be added when not effective element matchup occurs like fire against water and the same element matchup will result to a 1x damage multiplier in the damage calculation. In short this class adds strategy to the combat mechanism similar to other RPGs like Pokémon.

10. Level class
- This class stores the location name, story description and enemy associated with each level. It allows the player to select between the three different levels available in the program. This separates the game contents which are the levels from the game logic.

OOP concepts used :
- Encapsulation
- Inheritance
- Polymorphism
- Abstraction
- interface
