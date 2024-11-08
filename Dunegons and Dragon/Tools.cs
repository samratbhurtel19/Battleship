// Title: Dungeons & Dragons Tools Utility
// Author Name: Samrat Jayanta Bhurtel
// Date: November 8, 2024
// Student ID: 100949545
// Description:This static Tools class provides utility methods for the Dungeons & Dragons application.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunegons_and_Dragon
{
    public static class Tools
    {
        private static Random _random = new Random();  // Random instance for generating random numbers

        /// <summary>
        /// Simulates rolling a dice with the specified number of sides.
        /// </summary>
        /// <param name="sides">Number of sides on the dice</param>
        /// <returns>Random integer between 1 and the number of sides</returns>
        public static int RollDice(int sides)
        {
            return _random.Next(1, sides + 1);  // Return a random value between 1 and sides (inclusive)
        }
    }
}