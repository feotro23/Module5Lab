using System;

namespace Module5Lab
{
    internal class SuperPlayer : Player
    {
        // Additional properties or methods specific to SuperPlayer
        // For example:
        public void Fly()
        {
            Console.WriteLine("SuperPlayer is flying!");
        }

        public void Heal()
        {
            Console.WriteLine("SuperPlayer casts Heal! Gains 1 Life.");
            livesLeft ++;
        }
    }
}