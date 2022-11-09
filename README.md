# Programming-3D-worlds-mini-project
Overview of the game:
The idea for this game is to emulate the hectic feeling of playing DOOM but much, much, worse. The goal of the game is to kill as many enemies (and thus receive as many points) as you can within however long you want to play. 
The player has complete control over a capsule in a rectangular world. The player can move with input from WASD and SPACE to jump, as well as shoot a gun which sends a ray cast of 100f long (to help with aiming, a default Unity sprite called knob is used as a crosshair) . 
When the ray cast hits an object with the Target.cs script attached to it, it delivers 10 damage. Enemies give 1 score point upon death which updates a static variable that is then displayed in the TextMeshPro field in the UI under Score canvas. 
The mountain looking background was made using Terrain Tools, and the mountain protrusions were made using the brush tool provided by the package.


The main parts of the game are:
  
  •	Player – a capsule that is controlled with the WASD keys and mouse to look around, as well as jumping ability by pressing space. 
  
  •	Camera – a camera that moves to the position of a CameraPos object which is a child of Player gameobject
  
  •	Enemy – A rectangle that changes colour of the material based on how much health it has left, the enemy spawns with a randomly assigned health variable in a range of 10 to 99
  
  •	Score – Every enemy death awards 1 point which is visualized in the canvas to the top right of the screen where your total score is shown
  
  •	Enemy Spawner – A spawner that randomly spawns the enemies in a set range. 
  
  •	Gun – A gun that shoots a raycast of 100f when you click Fire1 button, which gives 10 damage to any object it hits that has the Target.cs script on it. 

# Game features:
  
  •	Positions of enemies are randomly selected each time helping with replayability.
  
  •	Enemies have randomly assigned health so you never know how many shots it takes to kill one.
  
  •	The game keeps track of a score

# Project parts:
  
  •	Scripts
    
    o	CameraMove – used to move the camera to the position of a child empty gameObject 
    
    o	CharacterMovement – self explanatory.
    
    o	ColorChanger – Changes the color of the enemies based on their health variable.
    
    o	FellOffTheMap – Destroys gameObjects that fall off the map when they reach -60f on the y axis. 
    
    o	GunShooting – Shoots a raycast of 100f distance when Mouse 1 is clicked.
    
    o	PlayerCam – Rotates the camera object when the mouse is moved.
    
    o	ScoreCounter – Updated the text on the Canvas that visualizes score
    
    o	Spawner – Randomly spawns enemies in the assigned X, Y and Z boundaries.
    
    o	Target – Is used to keep track of the enemies health and when they die they give 1+ point for the score.
    
    o	Wander – Makes the enemy have a wandering behavior.
  
  •	Models & Prefabs
  
    o	Enemy – Made with unity primitives 
  
    o	Player Object – Downloaded a UMP low poly asset from: https://free3d.com/3d-model/ump-45-389997.html and gave it a black material made in Unity.
  
  •	Materials
  
    o	Basic unity materials for the UMP and enemies
  
  •	Scenes
  
    o	Game has only one scene
  
  •	Testing
  
    o	Game was tested on Windows and has no versions other than development versions.
