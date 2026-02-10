using Module5Lab;

//Create a new player with one life and add points to the player's score
Player player = new Player("Frankenstein", 1);
player.AddPoints(100);

//Display the player's score
Console.WriteLine("Welcome to the game! Your score is: " + player.GetScore() + 
    " You have " + player.GetLivesLeft() + " lives left!");

//Kill off the player's character
player.Kill();

//Let the player know their character was killed
Console.WriteLine("An orc attacks you. Sorry, you were killed. You have " 
    + player.GetLivesLeft() + " lives left!");

// Create a super player
SuperPlayer superPlayer = new SuperPlayer();
superPlayer.AddPoints(500);
superPlayer.Fly(); // Demonstrate the additional ability
superPlayer.Heal(); //Adds 1 life
Console.WriteLine($"SuperPlayer score: {superPlayer.GetScore()}, Lives left: {superPlayer.GetLivesLeft()}");