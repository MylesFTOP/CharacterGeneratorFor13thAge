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

        [Fact]
        public void CharacterModel_HitPointsShouldCalculate() {
            uint expectedValue = 45;
            uint actualValue = characterModel.CalculateHitPoints(16,3);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
