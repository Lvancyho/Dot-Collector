# Dot Collector

Name & Role:
Ivan Ho - Solo team member

Roles & Responsibilities:
Responsible for all things within the project of Dot Collector

Precentage of all work:
100% from Ivan with some help from Jeffry for the factory design pattery. I was able to create the coins on my own but realized that the way I implemented it wasn't necessarily the factory design pattern taking place so Jeffry helped me out by explaining it and creating the parent class for the coins while I made the child classes. I also had to look into my old projects to refresh my memory on some useful lines of code such as my first year GDW game for listeners for observers and button mapping.

Explanation of what was done and how it was done:
I made the game Dot Collector by implementing the design patterns, singleton, factory, observer and command.
Singleton was implemented because it is my game manager and only 1 can exist at a time. If there are multiple, of the same singleton, then they'll delete themselves.
Factory was implemented by my coin system. A coin will spawn randomly and the factory will give it a chance to spawn as a gold coin or as a silver coin.
Observer was implemented with the score system. When a coin is picked up then the score listens to the player/coin being picked up so the score updates accordingly and destroys the coin.
Command was implemented to change the players color. At the beginning of the game, the player has the option to press 3 buttons to modify the color that they play as.

Description of the game:
Dot Collector is a 2D game where a player controls a dot and they have to collect coins around the map that spawn randomly to get the highest score possible while avoiding obstacles.

PSUEDO CODE:
My supporting psuedocode is within the scripts that I made but I will list them here as well just in case.

My Singleton is my game manager and and it uses an instance to help determine if it already exists at the moment and if another instance already exists then it will destroy the duplicates.
My Factory is a mix between 4 scripts. The first script would be the CoinSpawner script and this script looks at my prefabs I want it to spawn, and the places it could potentially spawn. After it looks at the prefabs it can spew out, it spawns a base and the base helps determine whether the coin spawns as a silver coin or a gold coin. After that the random coin spawns and then the observer takes over to look and help carry the rest of the commands.
My Observer takes a look at the coins spawns and sends a message to the score system and helps update the score accordingly determined on the value of the two coins. The silver coin is worth 5 points and the gold coin is worth 10 points. When the player collides with a coin, the system tells the score that its been notified and the notification causes an update which would be my score being updated. 
For Command, at the beginning of my game, I have three buttons which are mapped to change the players color. Simply put, the button just sends a command to the system letting it know something needs to happen which would be the players color being changed.

Interactive media scenario information:
Dot Collector is a 2D game where a player controls a dot and they have to collect coins around the map that spawn randomly to get the highest score possible while avoiding obstacles. I made this project to deliver the assignment's deliverables and help improve my skills with game engine design patterns. The player is expected to collect as many coins as possible before dying. The player can use WASD to move.

Project Management Tools:
https://docs.google.com/spreadsheets/d/1pROi6e8mVZiwnq9uwCtwJDRuuSgdIEAuEwlyYeTJ5BU/edit?usp=sharing Viewable by all Ontario Tech accounts

