# Individual Assignment 1
## General Information
I created a seperate version of the group game prior to the announcement stating we can use the same repo. However the base of the is the same as we are using a game we have already started working on prior to this class as stated in the proposal.

### Part 1
- [X] Dynamic game objects
- [X] A playable main character
- [X] An aesthetically pleasing scene
- [X] A win/lose condition

Game instructions are provided in the game but basically the objective is for the player to find his/her way out of a dark maze using a flashlight with a depleting battery life, if the flashlight battery dies before the player escapes they lose. Around the map are moving collectable batteries to replenish the flashlight battery life. 

### Part 2
- [X] Simple Specular
- [X] Diffuse Wrap

The two shaders I implemented in the game scene was the Simple Specular and Diffuse wrap which are applied to the material for the flashlight in the player's perspective, They are toggled using: </br>
1 - Simple Specular</br>
2 - Diffuse wrap</br>

Both shader scripts were coded using the lecture exercise scripts and unity docs.  For simple specular model, it is simply reflection where the material takes the lights color and direction on the object's albedo since specular itself doesn't have a color and produces somewhat of a shinniness. For diffuse wrap model, this is a modified diffuse lighting which wrap around the edges again using the light direction.

### Part 3
- [X] Warm LUT
- [X] Cool LUT
- [X] Custom LUT

Toggled using:</br>
3 - Warm</br>
4 - Cool</br>
5 - Custom</br>
0 - Normal</br>

The color grading shader was imlemented using the color grading scripts done in the lecture exercise where the script defines the amount of colors on the lookup table, gets the scene color, add precision to the sampling so it doesn't go beyond the LUT limits and calculates the offset to map the image to the LUT. Additionally, using the a c# script to copies source texture into destination render texture with a shader by using Graphics.Blit.</br>

The toggle for the color grading was implemented using a camera switch script which basically switches between 4 different cameras attached to the player with the different materials at the moment.

### Part 4
- [X] Rim Lighting
- [X] Normal Mapping

The rim lighting shader effect was added to the collectable battery object using the shader script done in the lecture with a few updates to take a texture. The normal mapping shader effect was implemented using the wall texture to give the walls a somewhat grimmy look to go with the texture map.

## Video Report

 

 

