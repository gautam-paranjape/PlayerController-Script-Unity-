# Unity Player Controller Script

This is a simple character/player controller script I made in Unity, using rigidbodies. Feel free to take the code. 

Movement is the most important thing in a game, and if you don't have movement, you can't do anything else.

The reason I released this script is so that new Unity developers can use this script, and focus on making their game.

This controller is all you need to get set up with basic movement in your Unity game.


---
## **Setup**
First, make sure you have a platform in your game, and name it **Ground**. 

Next, insert a capsule. This capsule will represent our player. Name the capsule **Player**, and position it so it's sitting on the Ground. 

Then, drag your **Main Camera** into the Player, so the camera is a child of it. Adjust the camera so that it sits on the player's head, like its eyes.

Then, insert a **Rigidbody** and **Script** component into your player. Go to constraints in your Rigidbody, and click freeze rotation on the x, y, and z axis. When you make your script, name it PlayerController, and open it up with your text editor.

Paste the code from the *PlayerController.cs* file into your script.

To make the Jump part work, click Ground, and click **Tag: Untagged**. It should show a couple of options, so click add tag, and click the plus icon, and name your tag **Ground**. 

Finally, go back to Ground selected, and set its tag to **Ground**

Hope you enjoy this script!