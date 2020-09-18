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
    }
}
