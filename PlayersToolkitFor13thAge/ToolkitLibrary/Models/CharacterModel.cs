using System;
using System.Collections.Generic;
using System.Text;

namespace ToolkitLibrary
{
    public class CharacterModel
    {
        public int CharacterID { get; set; }
        public string CharacterName { get; set; }
        public int PlayerID { get; set; }
        public string CharacterRace { get; set; }
        public string CharacterClass { get; set; }
        public int CharacterLevel { get; set; } 
        public uint Strength { get; set; } 
        public uint Constitution { get; set; } 
        public uint Dexterity { get; set; }
        public uint Wisdom { get; set; }
        public uint Intelligence { get; set; }
        public uint Charisma { get; set; }
        public int CurrentHitPoints { get; set; }
        //public CombatStat ArmorClass { get; private set; } = new CombatStat();
        //public CombatStat PhysicalDefense { get; private set; } = new CombatStat();
        //public CombatStat MentalDefense { get; private set; } = new CombatStat();
        //public int Recoveries { get; private set; }
        //public string RecoveryDice { get; private set; }
        //public List<string> IconRelationships { get; set; }
        //public List<Array> Backgrounds { get; set; }
        //public List<string> Feats { get; set; }
        //public List<string> Talents { get; set; }
        //public List<string> Skills { get; set; }
        //public List<string> Spells { get; set; }
        //public List<string> Items { get; set; }

        public CharacterModel() {

        }

        public CharacterModel(string characterName, string characterClass, string characterRace, string characterLevel,
            string strength, string constitution, string dexterity, string wisdom, string intelligence, string charisma, string currentHitPoints) {
            // TODO: Add logic for identifying users
            PlayerID = 21;

            CharacterName = characterName;
            CharacterClass = characterClass;
            CharacterRace = characterRace;
            CharacterLevel = int.Parse(characterLevel);

            Strength = uint.Parse(strength);
            Constitution = uint.Parse(constitution);
            Dexterity = uint.Parse(dexterity);
            Wisdom = uint.Parse(wisdom);
            Intelligence = uint.Parse(intelligence);
            Charisma = uint.Parse(charisma);
            CurrentHitPoints = int.Parse(currentHitPoints);
        }

        public int CalculateHitPoints (uint constitution, int characterLevel) { 
            AbilityStat a = new AbilityStat();

            // TODO: Add lookup for base value and multiplier for Hit Points
            int baseValue = 6; // default value for sorcerer - will need to look up against class
            int levelMultiplier = characterLevel + 2; // Only correct up to level 4 - will need to look up against class and level
            int hitPoints = (baseValue + a.CalculateModifier(constitution)) * levelMultiplier;
            return hitPoints;
        }
    }
}
