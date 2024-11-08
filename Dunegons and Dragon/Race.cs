// Title: Dungeons & Dragons Race Class
// Author Name: Samrat Jayanta Bhurtel
// Date: November 8, 2024
// Student ID: 100949545
// Description: This class defines different playable races for characters in the Dungeons & Dragons application.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunegons_and_Dragon
{
    public class Race
    {
        // Properties for race details and ability bonuses
        public string Name { get; set; }
        public string Description { get; set; }
        public int StrengthBonus { get; set; }
        public int DexterityBonus { get; set; }
        public int ConstitutionBonus { get; set; }
        public int IntelligenceBonus { get; set; }
        public int WisdomBonus { get; set; }
        public int CharismaBonus { get; set; }

        // Static list of default races with predefined bonuses and descriptions
        public static List<Race> DefaultRaces { get; } = new List<Race>
        {
            new Race { Name = "Dwarf", Description = "Sturdy and resilient.", StrengthBonus = 2, ConstitutionBonus = 2 },
            new Race { Name = "Elf (High)", Description = "Graceful and wise.", DexterityBonus = 2, IntelligenceBonus = 1 },
            new Race { Name = "Elf (Wood)", Description = "Stealthy and agile.", DexterityBonus = 2, WisdomBonus = 1 },
            new Race { Name = "Halfling", Description = "Small and nimble.", DexterityBonus = 2, CharismaBonus = 1 },
            new Race { Name = "Human", Description = "Versatile and adaptable.", StrengthBonus = 1, DexterityBonus = 1, ConstitutionBonus = 1, IntelligenceBonus = 1, WisdomBonus = 1, CharismaBonus = 1 },
            new Race { Name = "Dragonborn", Description = "Strong and charismatic.", StrengthBonus = 2, CharismaBonus = 1 },
            new Race { Name = "Gnome", Description = "Inventive and curious.", DexterityBonus = 1, ConstitutionBonus = 2 },
            new Race { Name = "Half-Elf", Description = "Adaptable and charismatic.", DexterityBonus = 1, CharismaBonus = 2 },
            new Race { Name = "Half-Orc", Description = "Strong and durable.", StrengthBonus = 2, ConstitutionBonus = 1 },
            new Race { Name = "Tiefling", Description = "Mysterious and charismatic.", CharismaBonus = 2, IntelligenceBonus = 1 },
            new Race { Name = "Githyanki", Description = "Disciplined and agile.", StrengthBonus = 1, DexterityBonus = 2 }
        };
    }
}