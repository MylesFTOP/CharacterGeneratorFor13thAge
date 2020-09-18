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

        public int CalculateArmorClass(int constitution, int dexterity, int wisdom, int characterLevel) {
            int baseValue = 10; // Hard-coded value for Sorcerer - see todo above

            int armorClass = CalculateCombatStat(baseValue, constitution, dexterity, wisdom, characterLevel);
            return armorClass;
        }

        public int CalculatePhysicalDefense(int strength, int constitution, int dexterity, int characterLevel) {
            int baseValue = 11; // Hard-coded value for Sorcerer - see todo above

            int physicalDefense = CalculateCombatStat(baseValue, strength, constitution, dexterity, characterLevel);
            return physicalDefense;
        }

        public int CalculateMentalDefense(int intelligence, int wisdom, int charisma, int characterLevel) {
            int baseValue = 10; // Hard-coded value for Sorcerer - see todo above

            int mentalDefense = CalculateCombatStat(baseValue, intelligence, wisdom, charisma, characterLevel);
            return mentalDefense;
        }

        private static int CalculateCombatStat(int classBaseValue, int firstAbilityStat, int secondAbilityStat, int thirdAbilityStat, int characterLevel) {
            AbilityStat a = new AbilityStat();
            
            int[] abilityStats = { firstAbilityStat, secondAbilityStat, thirdAbilityStat };
            Array.Sort(abilityStats);
            int combatStat = classBaseValue + a.CalculateModifierWithLevel(abilityStats[1], characterLevel);
            return combatStat;
        }
    }
}
