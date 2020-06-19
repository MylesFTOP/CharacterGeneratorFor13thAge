using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolkitLibrary
{
    public class CombatStat
    {
        public int CombatStatValue { get; private set; }
        // TODO: Add lookup for base value from character class to then pass to argument

        public int CalculateArmorClass(CharacterModel character) {
            int baseValue = 10; // Hard-coded value for Sorcerer - see todo above

            int armorClass = CalculateCombatStat(baseValue, character.Constitution, character.Dexterity, character.Wisdom, character.CharacterLevel);
            return armorClass;
        }

        public int CalculatePhysicalDefense(CharacterModel character) {
            int baseValue = 11; // Hard-coded value for Sorcerer - see todo above

            int physicalDefense = CalculateCombatStat(baseValue, character.Strength, character.Constitution, character.Dexterity, character.CharacterLevel);
            return physicalDefense;
        }

        public int CalculateMentalDefense(CharacterModel character) {
            int baseValue = 10; // Hard-coded value for Sorcerer - see todo above

            int mentalDefense = CalculateCombatStat(baseValue, character.Intelligence, character.Wisdom, character.Charisma, character.CharacterLevel);
            return mentalDefense;
        }

        public int CalculateCombatStat(int classBaseValue, uint firstAbilityStat, uint secondAbilityStat, uint thirdAbilityStat, uint characterLevel) {
            AbilityStat a = new AbilityStat();
            
            uint[] abilityStats = { firstAbilityStat, secondAbilityStat, thirdAbilityStat };
            Array.Sort(abilityStats);
            int combatStat = classBaseValue + a.CalculateModifierWithLevel(abilityStats[1], characterLevel);
            return combatStat;
        }
    }
}
