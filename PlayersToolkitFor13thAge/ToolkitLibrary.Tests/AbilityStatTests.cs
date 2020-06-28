using Xunit;

namespace ToolkitLibrary.Tests
{
    public class AbilityStatTests
    {
        private readonly AbilityStat abilityStat = new AbilityStat();

        [Theory]
        [InlineData(1, 13)]
        [InlineData(-1, 9)]
        public void AbilityStat_ModifierShouldCalculate(int expectedValue, uint stat) {
            int actualValue = abilityStat.CalculateModifier(stat);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void AbilityStat_ModifierWithLevelShouldCalculate() {
            int expectedValue = 2;
            int actualValue = abilityStat.CalculateModifierWithLevel(12, 1);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void AbilityStat_StringOverloadShouldReturnNumber() {
            AbilityStat abilityStatWithOverload = new AbilityStat("1");
            uint expectedValue = 1;
            uint actualValue = abilityStatWithOverload.AbilityStatValue;
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void AbilityStat_NumberOverloadShouldReturnNumber() {
            AbilityStat abilityStatWithOverload = new AbilityStat(1);
            uint expectedValue = 1;
            uint actualValue = abilityStatWithOverload.AbilityStatValue;
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
