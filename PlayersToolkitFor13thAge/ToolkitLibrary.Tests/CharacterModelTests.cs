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
            var previous = characterModel.CharacterName;
            characterModel.UpdateCharacterName("Test " + previous);
            var updated = characterModel.CharacterName;
            Assert.NotEqual(previous, updated);
        }

        [Fact]
        public void CharacterModel_UpdateCharacterRace_ShouldChangeCharacterRace() {
            var previous = characterModel.CharacterRace;
            characterModel.UpdateCharacterRace("Test " + previous);
            var updated = characterModel.CharacterRace;
            Assert.NotEqual(previous, updated);
        }

        [Fact]
        public void CharacterModel_UpdateCharacterClass_ShouldChangeCharacterClass() {
            var previous = characterModel.CharacterClass;
            characterModel.UpdateCharacterClass("Test " + previous);
            var updated = characterModel.CharacterClass;
            Assert.NotEqual(previous, updated);
        }

        [Fact]
        public void CharacterModel_UpdateCharacterLevel_ShouldChangeCharacterLevel() {
            var previous = characterModel.CharacterLevel;
            characterModel.UpdateCharacterLevel(previous + 1);
            var updated = characterModel.CharacterLevel;
            Assert.NotEqual(previous, updated);
        }

        [Fact]
        public void CharacterModel_UpdateCurrentHitPoints_ShouldChangeCurrentHitPoints() {
            var previous = characterModel.CurrentHitPoints;
            characterModel.UpdateCurrentHitPoints(previous - 1);
            var updated = characterModel.CurrentHitPoints;
            Assert.NotEqual(previous, updated);
        }

        [Fact]
        public void CharacterModel_HealCharacter_ShouldIncreaseHitPoints() {
            var expected = characterModel.CurrentHitPoints + 15;
            characterModel.HealCharacter(15);
            var updated = characterModel.CurrentHitPoints;
            Assert.Equal(expected, updated);
        }
    }
}
