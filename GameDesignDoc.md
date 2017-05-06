# Design Doc  
## Game Concept  
2D car driving around and hitting/missing objects (like metal slug clone we worked on before)  

## Genre  
2D platformer  

## Target Audience  
Kids/casual players  

## Game Flow  
Player starts as a car that moves trying to collect/avoid objects. Car will respawn at the beginning of the level unless a checkpoint is reached further along in the game. Levels should get increasingly more difficult. Objective of the game is to complete the levels and collect objects and avoid enemies.

## Mechanics  
### Player  
Driving forwards and backwards with Right or Left Arrows, respectively
“Jumping” with Up Arrow.  
If player reaches a checkpoint, if they die they should respawn at the last checkpoint reached. The last checkpoint in a level will take the player to a new level.  
Player dies if they do not avoid enemies in their way (if they touch the enemy). Can kill enemies with "Z"  
Player should want to collect all collectible items to add to the score.  
Pause Menu with “P”  

### Enemies  
Moving objects that can be destroyed by the player  
Can kill player if the player runs into them  

### Collectibles
Can range in point value?  (did not implement)  

### Platforms
Can move or be static  
Can be checkpoints  