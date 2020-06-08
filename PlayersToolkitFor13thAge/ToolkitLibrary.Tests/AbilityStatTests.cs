using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolkitLibrary;
using Xunit;

namespace ToolkitLibrary.Tests
{
    public class AbilityStatTests
    {
        private readonly AbilityStat abilityStat = new AbilityStat();

        [Theory]
        [InlineData(1, 13)]
        [InlineData(-1, 9)]
        public void AbilityStat_ModifierShouldCalculate(int expectedValue, int stat) {
            int actualValue = abilityStat.CalculateModifier(stat);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void AbilityStat_ModifierWithLevelShouldCalculate() {
            int expectedValue = 2;
            int actualValue = abilityStat.CalculateModifierWithLevel(12, 1);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
