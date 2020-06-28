using Xunit;

namespace ToolkitLibrary.Tests
{
    public class CharacterGeneratorTests
    {
        private readonly CharacterGenerator generator = new CharacterGenerator();

        [Fact]
        public void CharacterGenerator_ShouldGenerateAbilityStatBetween4And20() {
            uint actualValue = generator.GenerateRandomAbilityStat();
            Assert.InRange(actualValue, (uint)4, (uint)20);
        }
    }
}
