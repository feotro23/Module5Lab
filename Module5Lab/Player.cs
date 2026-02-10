using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Module5Lab
{
    /// <summary>
    /// Represents a player in the game, tracking their identity, progress, and health.
    /// </summary>
    internal class Player
    { // ---fields---
      // The player's name
        private string name;
        // The current score accumulated by the player
        private int score;

       // The current number of lives remaining
        private int livesLeft;
        // The max capacity for Lives
        private int maxLives = 10;

        //---Methods---
        
        ///<summary>
        /// Adjusts the player's life count and ensures it stays within valid bounds.
        /// Accessible only by this class and its derived (child) classes.
        /// </summary>
        
        /// The number of lives to add (positive) or subtract (negative).
        protected void ModifyLives(int amount)
        {
        livesLeft += amount;

        // Safety Check: Ensure lives don't exceed max or drop below zero
        if (livesLeft > maxLives) livesLeft = maxLives;
        if (livesLeft < 0) livesLeft = 0;

        // Trigger Side Effects: Notify the console of the change
        Console.WriteLine($"Lives are now: {livesLeft}");
        }

        /// <summary>
        /// Default constructor. Initializes a new instance of a player with default values.
        /// </summary>
        public Player()
        {
        }  

        /// <summary>
        /// Initializes a player with a specific name.
        /// </summary>
        public Player(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Initializes a player with a name and a starting number of lives.
        /// </summary>
        public Player(string name, int startingLives)
        {
            this.name = name;
            livesLeft = startingLives;
        }

        /// <summary>
        /// Retrieves the player's current total score.
        /// </summary>
        public int GetScore()
        {
            return score;
        }

        /// <summary>
        /// Increments the player's score by a specified amount.
        /// </summary>
        public void AddPoints(int totalPoints)
        {
            score += totalPoints;
        }

        /// <summary>
        /// Reduces the player's life count by one, ensuring it doesn't drop below zero.
        /// </summary>
        public void Kill()
        {
            // We make sure they can't get negative lives.
            if (livesLeft > 0)
            {
                livesLeft--;

            }
        }

        /// <summary>
        /// Checks how many lives the player has remaining.
        /// </summary>
        public int GetLivesLeft()
        {
            return livesLeft;
        }

    } //end class
} //end namespace