using System;

namespace Module5Lab
{
    /// <summary>
    /// Represents a specialized version of a Player with enhanced abilities.
    /// Inherits base functionality from the Player class.
    /// </summary>
    internal class SuperPlayer : Player
    {
        /// <summary>
        /// Unique ability for the SuperPlayer. 
        /// Outputs a flying message to the console.
        /// </summary>
        public void Fly()
        {
            Console.WriteLine("SuperPlayer is flying!");
        }

        /// <summary>
        /// Restores health to the SuperPlayer.
        /// </summary>
        public void Heal()
    {
        Console.WriteLine("SuperPlayer casts Heal!");
        // We ask the parent to update the lives safely.
        ModifyLives(1); 
    }
    }
}