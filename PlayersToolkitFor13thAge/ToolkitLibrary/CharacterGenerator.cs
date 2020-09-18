using System;
using System.Collections.Generic;
using System.Linq;

namespace ToolkitLibrary
{
    public class CharacterGenerator
    {
        readonly Dice dice = Factory.CreateDice();

        public int GenerateRandomAbilityStat() {
            List<int> abilityStatRolls = new List<int>()
                { dice.RollAbilityStat(), dice.RollAbilityStat() , dice.RollAbilityStat() , dice.RollAbilityStat() };
            abilityStatRolls.Sort();
            abilityStatRolls.RemoveAt(0);
            int randomAbilityStat = abilityStatRolls.Sum();
            return randomAbilityStat;
        }
    }
}
