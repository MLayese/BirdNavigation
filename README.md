# BirdNavigation
Made a pathfinding AI in the form of a bird
Code is for a Unity project created during class. This was a collaboration project between myself and Bilkent Samsurya. 

The AI utilizes three different routines: **Objective, Follow,** and **Hover**.

### Objective:
Find an object and oscillates between the given points using an enumeration function. To modify the object followed change the for loop variable from ```cube``` to whatever the objectname is.

### Follow:
Give the AI a target to follow and it will mimic its coordinates. This is a public variable so you're able to change it within Unity.

### Hover:
Hover around the target from the **Follow** routine. 

#### Things to do:
So far the X and Z coordinates are being followed but the y coordinate does not move in relation to the others. The AI can't distinguish elevation and will simply go through objects as if it were all in a straight horizontal line. Need to fix the code so it can distinguish elevation and the y axis.

The AI is orientated to just one direction. It will not change which way it's facing. I should change this.

Figure out a way to trigger different functions without manually editing them in Unity - do it within the game.

