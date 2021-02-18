using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ToolkitLibrary.Tests
{
    public class CharacterModelTests
    {
        private readonly CharacterModel characterModel = new CharacterModel();

        [Theory]
        [InlineData(45, 16, 3)]
        [InlineData(36, 16, 2)]
        public void CharacterModel_HitPointsShouldCalculate(int expectedValue, int constitution, int characterLevel) {
            int actualValue = characterModel.CalculateHitPoints(constitution, characterLevel);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void CharacterModel_Ctor_ShouldTakeStringsAsArguments() {
            var actual = new CharacterModel("test name", "test class", "test race", "1", "12", "12", "12", "12", "12", "12", "21");
            Assert.IsType<CharacterModel>(actual);
        }

        [Fact]
        public void CharacterModel_UpdateCharacterName_ShouldChangeCharacterName() {
            var before = characterModel.CharacterName;
            characterModel.UpdateCharacterName("Test " + before);
            var after = characterModel.CharacterName;
            Assert.NotEqual(before, after);

        }

        [Fact]
        public void CharacterModel_UpdateCharacterRace_ShouldChangeCharacterRace() {
            var before = characterModel.CharacterRace;
            characterModel.UpdateCharacterRace("Test " + before);
            var after = characterModel.CharacterRace;
            Assert.NotEqual(before, after);

        }

        [Fact]
        public void CharacterModel_UpdateCharacterClass_ShouldChangeCharacterClass() {
            var before = characterModel.CharacterClass;
            characterModel.UpdateCharacterClass("Test " + before);
            var after = characterModel.CharacterClass;
            Assert.NotEqual(before, after);

        }

        [Fact]
        public void CharacterModel_UpdateCharacterLevel_ShouldChangeCharacterLevel() {
            var before = characterModel.CharacterLevel;
            characterModel.UpdateCharacterLevel(before + 1);
            var after = characterModel.CharacterLevel;
            Assert.NotEqual(before, after);

        }
    }
}
