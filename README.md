# GDIM33 Vertical Slice
## Milestone 1 Devlog
### Part 1
1. Inside my player movement visual script graph, I have a graph that sets the animation of the player depending on where the mouse is located. The graph starts with an update and sets the float “speed” inside of the animator which tells the blend tree which running animation to play. Then I take the Aim Direction which is a vector two variable and check if it has an X and Y value (non zero). If it’s not empty (meaning there is a X and Y position) I get the Aim Direction variable’s X and Y and set the Horizontal and Vertical variable inside the animator. This will tell the blend tree which idle animation to play depending on the mouse position of the player.  

### Part 2
<img width="1202" height="744" alt="image" src="https://github.com/user-attachments/assets/7b07d368-ddd4-44e0-8336-4ba81e855014" />

1. In my breakdown, it now features two different Unity tools that I use in my project. I have a tilemap for laying out my map which features layers for the floor, walls, and decorations. I also have an animator for the players character and zombies animations and have them play correctly. Lastly, I added the zombie game objects state machine. Every zombie will have this state machine. Zombies will either be alive and chasing the player or dead.
2. In the alive state, the zombie interacts with the player's weapon system, where if the bullet the player fires collides with the zombies trigger collider, it deals damage to the zombie. Also within the alive state, it takes the same system that calculates the player's position and uses that to always move towards the player. Once the player is within a certain range, it attacks. Once the player shoots the zombie enough and its HP falls to zero, the alive state makes a transition to the dead state which disables the zombies colliders and plays the death animation. After a few seconds the zombie object is deleted. 


## Milestone 2 Devlog
### Part 1
#### Wave Spawnner
1. Create a point where a script will run to spawn enemies
    1. Add empty object to the game
    2. Create visual script that will instantiate the zombie object at the given point
    3. Add an timer to script that will spawn zombies at certain intervals
    4. Set up a script to limit the max amount of zombies that can be spawn per round
2. When player clears enemies, move to next round with increased enemy spawns
    1. If player eliminates the max amount of zombies for that round, increase the max zombie limit within script
    2. Add variable to track number of zombies killed by player
    3. Create new variable within script called Round
    4. Add one to Round per time the player eliminates the maximum zombies for the previous round
    5. Create UI element that increases and displays with the round count variable

### Part 2
1. Overall I think writing all the steps out does help me visualize the code better and get a sense of which nodes I'm going to need to create this feature. To improve the breakdown, I wish I knew which nodes I needed specifically so that the process of implementation would be a lot more simple. So adding more details would've been very helpful, however it still allowed me to break down the steps and it felt like going through small checkpoints as I was implementing the new feature.
   
### Part 3
1. In this part of my Enemy isDead state graph, I am calling the add score method inside my pointsTrackers script. Here, I am basically adding points to the players point count whenever the player kills a zombie. This is here so that the players will gain more points upon killing the zombies and are rewarded for doing so. 
<img width="1561" height="443" alt="image" src="https://github.com/user-attachments/assets/b865b962-425f-46cf-aed4-97f7df489e88" />

### Part 4
1. I use the Unity animator on my character, gun, and zombies. I use it to play the correct animations depending on state and direction which is done through a blend tree with conditions. 

## Milestone 3 Devlog
### Part 1
<img width="1085" height="598" alt="image" src="https://github.com/user-attachments/assets/576a08ba-269f-4010-a034-f6665011b4d6" />

1. This is my PerkShine shader graph which is used to make the player health upgrade statue glow. In it, I use the time node and multiply it by a value of 2 so that time is sped up so that the animation players faster. After multplying time, I feed it into a sine node which then creates this blinking/oscillation effect since sine waves go up and down (from -1 to 1) and when multplied by time, it'll create moments of darkness and light. Then it goes into a remap node which shifts the intensity of the brightness of the color. Then from the top section we multiply the maintex with the glow color (in my case this bright red) and multiply it by the remap to create a red blinking animation. 

### Part 2
1. Based on feedback, I've lowered the round color on the bottom left since players felt that it was to bright before. I've also added a light shader to the bullet to make it brighter, a explosion effect when the bullet collides with enemy or wall, UI pop up when next to purchasables, fixed gun desync when players run into walls, fixed player jittering when running into a wall, removed the open fence sprite to help confusion with walkable areas, and fixed error where players could buy the health perk over and over to heal.  

### Part 3
1. A new feature I added, was the purchasable gun upgrade at the bottom of the map. Players can now buy the door towards the bottom left of the map and spend 5000 points to upgrade their gun which then will become very powerful. This will allow the player to get through rounds quicker and use less ammo to do so. This will effect the main gameplay loop alot since it makes the game easier but it does make you gain less points per kill since you'll be killing the zombies faster than before (you gain points per bullet hit). 

## Final Devlog
### Part 1
1. My game at its core is a round based survival horror game where players can buy upgrades and become powerful and take out large hoards of enemies. Currently the content in the game reflect this core gameplay loop. Players can updrage their weapon which allows them to deal extra damage per shot, they can buy ammo at any point by interacting with the ammo crate, and interact with a glowing godess statue which will grant them extra health which improves survivability. I also have implemented a door feature where players must spend points inorder to unlock new parts of the map. This will encourage players to explore and open all the maps since through the door, they find new upgrades and other purchasables. This is esstenitally the core loop for players in the full game. Players will be surviving as long as possible and buying upgrades and exploring as the rounds increase. In the full game however, there would be different weapons and perks the players can get. Also there would be an optional quest on the map where if the players complete each step required, will lead to an boss fight.

### Part 2
<img width="1182" height="431" alt="image" src="https://github.com/user-attachments/assets/1c751f24-8a6c-4b2d-a1d5-64a0f47161ce" />
1. For my rendering effect, I decided to change the color of the material for my perk glow effect after the player purchases the perk. Initially in game, the perk flashes red, indicating both red for health and draws the players attention. As you can see from the visual script, after the player buys the perk and the points are subtractd, I set the PerkGlow material to be a yellow color. This then changes the base color for the perk glow material in the shader perk glow graph and the perk will now flash a yellow glow instead of the initial red. 


## Open-source assets
- Cite any external assets used here!
