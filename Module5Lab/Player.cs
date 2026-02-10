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
    { /// fields
        private string name;
        
        private int score;

        // 'protected' allows derived classes (like a SuperPlayer) to access this directly
        protected int livesLeft;

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