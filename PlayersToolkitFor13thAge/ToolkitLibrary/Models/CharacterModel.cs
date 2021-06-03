using System;
using System.Collections.Generic;
using System.Text;

namespace ToolkitLibrary
{
    public class CharacterModel
    {
        public int CharacterId { get; set; }
        public string CharacterName { get; private set; }
        public int PlayerId { get; set; }
        public string CharacterRace { get; private set; }
        public string CharacterClass { get; private set; }
        public int CharacterLevel { get; private set; }
        public int Strength { get; private set; } 
        public int Constitution { get; private set; } 
        public int Dexterity { get; private set; }
        public int Wisdom { get; private set; }
        public int Intelligence { get; private set; }
        public int Charisma { get; private set; }
        public int CurrentHitPoints { get; private set; }
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
            PlayerId = 21;

            CharacterName = characterName;
            CharacterClass = characterClass;
            CharacterRace = characterRace;
            CharacterLevel = int.Parse(characterLevel);

            SetAbilityStats(strength, constitution, dexterity, wisdom, intelligence, charisma);

            CurrentHitPoints = int.Parse(currentHitPoints);
        }

        private void SetAbilityStats(string strength, string constitution, string dexterity, string wisdom, string intelligence, string charisma) {
            Strength = int.Parse(strength);
            Constitution = int.Parse(constitution);
            Dexterity = int.Parse(dexterity);
            Wisdom = int.Parse(wisdom);
            Intelligence = int.Parse(intelligence);
            Charisma = int.Parse(charisma);
        }

        public int CalculateHitPoints (int constitution, int characterLevel) { 
            AbilityStat a = Factory.CreateAbilityStat();

            // TODO: Add lookup for base value and multiplier for Hit Points
            int baseValue = 6; // default value for sorcerer - will need to look up against class
            int levelMultiplier = characterLevel + 2; // Only correct up to level 4 - will need to look up against class and level
            int hitPoints = (baseValue + a.CalculateModifier(constitution)) * levelMultiplier;
            return hitPoints;
        }

        public void UpdateCharacterName(string newName) {
            CharacterName = newName;
        }

        public void UpdateCharacterRace(string newRace) {
            CharacterRace = newRace;
        }

        public void UpdateCharacterClass(string newClass) {
            CharacterClass = newClass;
        }

        public void UpdateCharacterLevel(int newLevel) {
            CharacterLevel = newLevel;
        }

        public void UpdateCurrentHitPoints(int newHitPoints) {
            CurrentHitPoints = newHitPoints;
        }
    }
}
