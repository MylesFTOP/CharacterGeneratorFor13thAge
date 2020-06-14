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

        public static int CalculateArmorClass(CharacterModel character) {
            int baseValue = 10; // Hard-coded value for Sorcerer - see todo above

            int armorClass = CalculateCombatStat(baseValue, character.Constitution, character.Dexterity, character.Wisdom);
            return armorClass;
        }

        public static int CalculatePhysicalDefense(CharacterModel character) {
            int baseValue = 11; // Hard-coded value for Sorcerer - see todo above

            int physicalDefense = CalculateCombatStat(baseValue, character.Strength, character.Constitution, character.Dexterity);
            return physicalDefense;
        }

        public static int CalculateMentalDefense(CharacterModel character) {
            int baseValue = 10; // Hard-coded value for Sorcerer - see todo above

            int mentalDefense = CalculateCombatStat(baseValue, character.Intelligence, character.Wisdom, character.Charisma);
            return mentalDefense;
        }

        private static int CalculateCombatStat(int classBaseValue, uint firstAbilityStat, uint secondAbilityStat, uint thirdAbilityStat) {
            uint[] abilityStats = { firstAbilityStat, secondAbilityStat, thirdAbilityStat };
            Array.Sort(abilityStats);
            int combatStat = classBaseValue + Array.IndexOf(abilityStats, 1);
            return combatStat;
        }
    }
}
