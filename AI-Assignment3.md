Assignment 3: AI  
Aidan Boyd

**How AI behaviors influence player strategy and decision-making.**   
	Like the last assignment I will detail what I was trying to achieve while touching on the final result.   
	There were multiple sections I was going to set up that would be different in each room. I was going to start with a stealth-like section to evade enemy movement to find a key to leave the room. I was going to use the code we learned in class to have set waypoints each enemy in the room would follow, and have objects you could throw to distract them.   
Next would be a more darkly lit area where you have a flashlight to go through a maze. There would be 3 other enemies also with flashlights that would detect the range of your flashlight and move towards it. You can turn the light on and off to hide your position, while being able to see where the enemy is.   
Last part would be or survive for a set time with enemies rapidly spawning at 4 positions. You are able to shoot a red cube at them with enemies being a one hit kill. There isn't too much strategy other than trying to eliminate as many enemies as you can while beading them. Survive long enough and you win the game.    

**How player actions dynamically alter AI states and responses.**  
	The player is aware of what states the AI can enter, and exit. You can adapt to your surroundings, memorizing their patterns, and strategically evade them.  I did not give myself enough time to try testing the sound awareness.   
With the flashlight area you can turn it on and off to trick enemies where you are heading towards. You can wait for them to go by, then go the way they were coming from. There is no other gameplay in this area besides going through the maze with your flashlight while distracting enemies with it. There is no code of this in the final project  
Finally is the survival wave based mode which is the only thing in the final project. The enemy is constantly going towards the player making them move all around the room shooting at each target until no more are spawning. The end goal is not featured in the final project. It is enemies spawning with no set amount.  

**Challenges faced during implementation and their solutions.**    
	I am going to focus on the end result because that took up the entirety of my time. The big thing I was trying to put together for my AI assignment was inspired by wave based modes to survive as long as you can.   
	I had difficulty getting the shooting ready to hit the enemy to work with the spawner. Once you hit the parent object in the scene it would no longer try to access it, and the spawner would stop spawning clones. I was butting my head trying different ways in the code to make it work to no avail. That’s when I realized it was not a coding issue but rather a scene issue. I was telling the spawner to keep spawning the object in the scene instead of the prefab in my assets. I took the asset object out of the scene and the spawner kept spawning enemies after killing each one  
	Next issue I ran into was setting up ht points for the player, and the enemy. Once the enemy made contact with the player I wanted it to take damage. I originally had it set up as OnCollisionEnter, and it did not work every time I tried testing a new line of code.   
	Health \-= 1  
	Destroy(gameObject) \- this of course just killed the player   
	  
	Honestly forget how many ways I tried it because I was at this part for 3-4 hours. The final solution which I wished I could explain correctly is OnTriggerEnter. I guess before was not the correct way to detect the enemy colliding with the player. I also had to put this in the enemy script with the line other.gameObject.GetComponent\<PlayerController\>().health \-=1; It had to reference the player controller script to know what it is contacting and deal one damage.     
	Finally I tested out trying to get the spawner to work once the player enters an area. This was not resolved in the final project. I tried using OnTriggerEnter again and instead referenced the Spawner and set spawningbool \= true. It did not work no matter how many times I tried entering different ways of code. I had to stop there as the assignment was due. 