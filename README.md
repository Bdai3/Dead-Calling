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
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- Cite any external assets used here!
