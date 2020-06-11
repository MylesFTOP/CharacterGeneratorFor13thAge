using System;
using System.Collections.Generic;
using System.Text;

namespace ToolkitLibrary
{
    public class AbilityStat
    {
        public uint AbilityStatValue { get; set; }

        public AbilityStatType AbilityStatName { get; private set; }
        public int Modifier { get; private set; }
        public int ModifierWithLevel { get; private set; }

        public int CalculateModifier(uint abilityStat) {
            double modifier = Math.Floor(((double)abilityStat - 10) / 2);
            return (int)modifier;
        }

        public int CalculateModifierWithLevel(uint abilityStat, int characterLevel) {
            int modifierWithLevel = CalculateModifier(abilityStat) + characterLevel;
            return modifierWithLevel;
        }

        public AbilityStat() {

        }

        public AbilityStat(uint inputValue) {
            AbilityStatValue = inputValue;
        }

        public AbilityStat(string inputValue) {
            AbilityStatValue = uint.Parse(inputValue);
        }

        public enum AbilityStatType
        {
            strength,
            constitution,
            dexterity,
            wisdom,
            intelligence,
            charisma,
        }
    }
}
