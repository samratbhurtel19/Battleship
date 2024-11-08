// Title: Dungeons & Dragons Character Class
// Author Name: Samrat Jayanta Bhurtel
// Date: November 8, 2024
// Student ID: 100949545
// Description: This class represents a character in the Dungeons & Dragons application.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunegons_and_Dragon
{
    public class Character
    {
        // Properties for character details and attributes
        public string Name { get; set; }
        public Class CharacterClass { get; set; }
        public Race CharacterRace { get; set; }
        public Constants.Alignment Alignment { get; set; }
        public string Gender { get; set; }
        public int Level { get; set; } = 1;
        public int ExperiencePoints { get; set; } = 0;
        public int Strength { get; set; } = 8;
        public int Dexterity { get; set; } = 8;
        public int Constitution { get; set; } = 8;
        public int Intelligence { get; set; } = 8;
        public int Wisdom { get; set; } = 8;
        public int Charisma { get; set; } = 8;
        public int Initiative { get; set; } = 0;
        public int Speed { get; set; } = 0;
        public int HitPoints { get; set; } = 0;

        // Static list to store all characters created
        public static List<Character> Characters { get; } = new List<Character>();

        /// <summary>
        /// Applies racial bonuses to the character's attributes based on their race
        /// </summary>
        public void ApplyRaceBonuses()
        {
            // Add race-specific bonuses to character attributes
            Strength += CharacterRace.StrengthBonus;
            Dexterity += CharacterRace.DexterityBonus;
            Constitution += CharacterRace.ConstitutionBonus;
            Intelligence += CharacterRace.IntelligenceBonus;
            Wisdom += CharacterRace.WisdomBonus;
            Charisma += CharacterRace.CharismaBonus;
        }
    }
}
