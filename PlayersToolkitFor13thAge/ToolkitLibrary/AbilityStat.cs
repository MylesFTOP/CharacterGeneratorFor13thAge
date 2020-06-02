using System;
using System.Collections.Generic;
using System.Text;

namespace ToolkitLibrary
{
    public class AbilityStat
    {

        public int CalculateModifier(uint abilityStat) {
            double abilityStatAsDouble = abilityStat;
            double modifierCalc = Math.Floor((abilityStatAsDouble - 10) / 2);
            int modifier = int.Parse($"{modifierCalc}");
            return modifier;
        }

        public int CalculateModifierWithLevel(uint abilityStat, int characterLevel) {
            int modifierWithLevel = CalculateModifier(abilityStat) + characterLevel;
            return modifierWithLevel;
        }
    }
}
