using System;
using System.Collections.Generic;
using System.Linq;

namespace ToolkitLibrary
{
    public class CharacterGenerator
    {
        readonly Dice dice = Factory.CreateDice();

        public List<int> GenerateRandomSetOfAbilityStats() {
            List<int> abilityStats = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                abilityStats.Add(GenerateRandomAbilityStat());
            }
            return abilityStats;
        }

        public int GenerateRandomAbilityStat() {
            List<int> abilityStatRolls = new List<int>();
            for (int i = 0; i < 4; i++)
            { abilityStatRolls.Add(dice.RollAbilityStat()); }
            abilityStatRolls.Sort();
            abilityStatRolls.RemoveAt(0);
            int randomAbilityStat = abilityStatRolls.Sum();
            return randomAbilityStat;
        }
    }
}
