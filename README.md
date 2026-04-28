# GDIM33 Vertical Slice
## Milestone 1 Devlog
### Part 1
1. Inside my player movement visual script graph, I have a graph that sets the animation of the player depending on where the mouse is located. The graph starts with an update and sets the float “speed” inside of the animator which tells the blend tree which running animation to play. Then I take the Aim Direction which is a vector two variable and check if it has an X and Y value (non zero). If it’s not empty (meaning there is a X and Y position) I get the Aim Direction variable’s X and Y and set the Horizontal and Vertical variable inside the animator. This will tell the blend tree which idle animation to play depending on the mouse position of the player.  

### Part 2
<img width="1202" height="744" alt="image" src="https://github.com/user-attachments/assets/7b07d368-ddd4-44e0-8336-4ba81e855014" />

1. In my breakdown, it now features two different Unity tools that I use in my project. I have a tilemap for laying out my map which features layers for the floor, walls, and decorations. I also have an animator for the players character and zombies animations and have them play correctly. Lastly, I added the zombie game objects state machine. Every zombie will have this state machine. Zombies will either be alive and chasing the player or dead.
2. In the alive state, the zombie interacts with the player's weapon system, where if the bullet the player fires collides with the zombies trigger collider, it deals damage to the zombie. Also within the alive state, it takes the same system that calculates the player's position and uses that to always move towards the player. Once the player is within a certain range, it attacks. Once the player shoots the zombie enough and its HP falls to zero, the alive state makes a transition to the dead state which disables the zombies colliders and plays the death animation. After a few seconds the zombie object is deleted. 


## Milestone 2 Devlog
Milestone 2 Devlog goes here.
## Milestone 3 Devlog
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- Cite any external assets used here!
