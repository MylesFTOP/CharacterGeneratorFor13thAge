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
            // TODO : Add lookup for base value from character class to then pass to argument
            int baseValue = 16;

            int[] abilityStats = { character.Constitution, character.Dexterity, character.Wisdom };
            Array.Sort(abilityStats);
            int armorClass = baseValue + (int)Array.IndexOf(abilityStats, 1);
             // CalculateCombatStat(baseValue, character.Constitution, character.Dexterity, character.Wisdom);

            return armorClass;
        }

        //private static int CalculateCombatStat(int classBaseValue, AbilityStat firstAbilityStat, AbilityStat secondAbilityStat, AbilityStat thirdAbilityStat) {
        //    Array abilityStats[] = [firstAbilityStat, secondAbilityStat, thirdAbilityStat];
        //    abilityStats = Array.Sort(abilityStats[]);
        //    int combatStat = classBaseValue + (int)Array.IndexOf(abilityStats[], 1);
        //    return combatStat;
        //}
    }
}
