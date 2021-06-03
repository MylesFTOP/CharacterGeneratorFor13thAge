using System;

namespace ToolkitLibrary
{
    public struct AbilityStat
    {
        public int AbilityStatValue { get; private set; }

        public int CalculateModifier(int abilityStat) {
            double modifier = Math.Floor(((double)abilityStat - 10) / 2);
            return (int)modifier;
        }

        public int CalculateModifierWithLevel(int abilityStat, int characterLevel) {
            return CalculateModifier(abilityStat) + characterLevel;
        }

        public AbilityStat(int inputValue) {
            AbilityStatValue = inputValue;
        }

        public AbilityStat(string inputValue) {
            AbilityStatValue = int.Parse(inputValue);
        }
    }
}
