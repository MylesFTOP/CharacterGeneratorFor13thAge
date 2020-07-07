using System;
using System.Collections.Generic;
using System.Linq;

namespace ToolkitLibrary
{
    public class CharacterGenerator
    {
        readonly Dice dice = Factory.CreateDice();

        public uint GenerateRandomAbilityStat() {
            List<int> abilityStatRolls = new List<int>()
                { (int)dice.RollAbilityStat(), (int)dice.RollAbilityStat() , (int)dice.RollAbilityStat() , (int)dice.RollAbilityStat() };
            abilityStatRolls.Sort();
            abilityStatRolls.RemoveAt(0);
            uint randomAbilityStat = (uint)abilityStatRolls.Sum();
            return randomAbilityStat;
        }
    }
}
