// Title: Dungeons & Dragons Constants Class
// Author Name: Samrat Jayanta Bhurtel
// Date: November 8, 2024
// Student ID: 100949545
// Description:This static Constants class provides predefined values for use within the Dungeons & Dragons application.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunegons_and_Dragon
{
    public static class Constants
    {
        // Enumeration representing D&D character alignments
        public enum Alignment
        {
            LawfulGood,
            NeutralGood,
            ChaoticGood,
            LawfulNeutral,
            Neutral,
            ChaoticNeutral,
            LawfulEvil,
            NeutralEvil,
            ChaoticEvil
        }

        // Array of standard attribute names
        public static string[] AttributeNames =
        {
            "Strength",
            "Dexterity",
            "Constitution",
            "Intelligence",
            "Wisdom",
            "Charisma"
        };
    }
}
