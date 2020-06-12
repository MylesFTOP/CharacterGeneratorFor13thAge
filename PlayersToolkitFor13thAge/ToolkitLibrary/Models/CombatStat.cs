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

        public static int CalculateArmorClass(CharacterModel character) {
            // TODO: Add lookup for base value from character class to then pass to argument
            int baseValue = 16;

            int armorClass = CalculateCombatStat(baseValue, character.Constitution, character.Dexterity, character.Wisdom);
            return armorClass;
        }

        // TODO: Add methods to calculate PD and MD

        private static int CalculateCombatStat(int classBaseValue, uint firstAbilityStat, uint secondAbilityStat, uint thirdAbilityStat) {
            uint[] abilityStats = { firstAbilityStat, secondAbilityStat, thirdAbilityStat };
            Array.Sort(abilityStats);
            int combatStat = classBaseValue + Array.IndexOf(abilityStats, 1);
            return combatStat;
        }
    }
}
