using Xunit;

namespace ToolkitLibrary.Tests
{
    public class CharacterGeneratorTests
    {
        private readonly CharacterGenerator generator = new CharacterGenerator();

        [Fact]
        public void CharacterGenerator_ShouldGenerateAbilityStatBetween4And20() {
            int actualValue = generator.GenerateRandomAbilityStat();
            Assert.InRange(actualValue, 4, 20);
        }

        [Fact]
        public void CharacterGenerator_GenerateRandomSetOfAbilityStatsShouldGenerate6Stats() {
            var expectedValue = 6;
            var actualValue = generator.GenerateRandomSetOfAbilityStats().Count;
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
