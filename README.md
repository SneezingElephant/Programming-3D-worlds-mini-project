# Programming-3D-worlds-mini-project
The idea for this game is to emulate the hectic feeling of playing DOOM but much, much, worse. The goal of the game is to kill as many enemies (and thus receive as many points) as you can within however long you want to play. 
The player has complete control over a capsule in a rectangular world. The player can move with input from WASD and SPACE to jump, as well as shoot a gun which sends a ray cast of 100f long (to help with aiming, a default Unity sprite called knob is used as a crosshair) . 
When the ray cast hits an object with the Target.cs script attached to it, it delivers 10 damage. Enemies give 1 score point upon death which updates a static variable that is then displayed in the TextMeshPro field in the UI under Score canvas. 


The mountain looking background was made using Terrain Tools, and the mountain protrusions were made using the brush tool provided by the package.
