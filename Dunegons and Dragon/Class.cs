// Title: Dungeons & Dragons Class Definition
// Author Name: Samrat Jayanta Bhurtel
// Date: November 8, 2024
// Student ID: 100949545
// Description: This class defines the various playable character classes in the Dungeons & Dragons application.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunegons_and_Dragon
{
    public class Class
    {
        // Properties defining class attributes and abilities
        public string Name { get; set; }
        public string Description { get; set; }
        public int HPDice { get; set; }  // Hit points dice size per level
        public string PrimaryAbility { get; set; }
        public string PrimarySave { get; set; }
        public string SecondarySave { get; set; }

        // Static list of predefined classes with specific attributes and abilities
        public static List<Class> DefaultClasses { get; } = new List<Class>
        {
            new Class { Name = "Barbarian", Description = "A strong and resilient warrior.", HPDice = 12, PrimaryAbility = "Strength", PrimarySave = "Strength", SecondarySave = "Constitution" },
            new Class { Name = "Bard", Description = "A versatile performer and spellcaster.", HPDice = 8, PrimaryAbility = "Dexterity", PrimarySave = "Dexterity", SecondarySave = "Charisma" },
            new Class { Name = "Cleric", Description = "A healer and protector with divine powers.", HPDice = 8, PrimaryAbility = "Wisdom", PrimarySave = "Wisdom", SecondarySave = "Charisma" },
            new Class { Name = "Druid", Description = "A spellcaster with a connection to nature.", HPDice = 8, PrimaryAbility = "Intelligence", PrimarySave = "Intelligence", SecondarySave = "Wisdom" },
            new Class { Name = "Fighter", Description = "A skilled combatant and defender.", HPDice = 10, PrimaryAbility = "Strength", PrimarySave = "Strength", SecondarySave = "Constitution" },
            new Class { Name = "Monk", Description = "A martial artist with spiritual power.", HPDice = 8, PrimaryAbility = "Dexterity", PrimarySave = "Dexterity", SecondarySave = "Strength" },
            new Class { Name = "Paladin", Description = "A holy warrior with healing powers.", HPDice = 10, PrimaryAbility = "Strength", PrimarySave = "Wisdom", SecondarySave = "Charisma" },
            new Class { Name = "Ranger", Description = "A skilled hunter and tracker.", HPDice = 10, PrimaryAbility = "Dexterity", PrimarySave = "Strength", SecondarySave = "Dexterity" },
            new Class { Name = "Rogue", Description = "A stealthy and agile combatant.", HPDice = 8, PrimaryAbility = "Dexterity", PrimarySave = "Intelligence", SecondarySave = "Dexterity" },
            new Class { Name = "Sorcerer", Description = "A spellcaster with innate magical ability.", HPDice = 6, PrimaryAbility = "Charisma", PrimarySave = "Constitution", SecondarySave = "Charisma" },
            new Class { Name = "Warlock", Description = "A spellcaster who gains power from a pact.", HPDice = 8, PrimaryAbility = "Charisma", PrimarySave = "Wisdom", SecondarySave = "Charisma" },
            new Class { Name = "Wizard", Description = "A scholarly spellcaster with vast knowledge.", HPDice = 6, PrimaryAbility = "Intelligence", PrimarySave = "Intelligence", SecondarySave = "Wisdom" }
        };
    }
}
