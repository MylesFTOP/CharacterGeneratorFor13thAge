using System;

namespace ToolkitLibrary
{
    public class AbilityStat
    {
        public int AbilityStatValue { get; set; }

        public int CalculateModifier(int abilityStat) {
            double modifier = Math.Floor(((double)abilityStat - 10) / 2);
            return (int)modifier;
        }

        public int CalculateModifierWithLevel(int abilityStat, int characterLevel) {
            int modifierWithLevel = CalculateModifier(abilityStat) + characterLevel;
            return modifierWithLevel;
        }

        public AbilityStat() {

        }

        public AbilityStat(int inputValue) {
            AbilityStatValue = inputValue;
        }

        public AbilityStat(string inputValue) {
            AbilityStatValue = int.Parse(inputValue);
        }
    }
}
