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
        public void CharacterModel_HitPointsShouldCalculate(uint expectedValue, uint constitution, uint characterLevel) {
            uint actualValue = characterModel.CalculateHitPoints(constitution, characterLevel);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
