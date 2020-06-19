using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ToolkitLibrary.Tests
{
    public class CombatStatTests
    {
        private readonly CombatStat combatStat = new CombatStat();

        CharacterModel model = new CharacterModel("test", "test", "test", "3", "13", "16", "14", "14", "13", "19");

        [Fact]
        public void CombatStat_ArmorClassShouldCalculate() {
            int expectedValue = 15;
            int actualValue = combatStat.CalculateArmorClass(model);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void CombatStat_PhysicalDefenseShouldCalculate() {
            int expectedValue = 16;
            int actualValue = combatStat.CalculatePhysicalDefense(model);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void CombatStat_MentalDefenseShouldCalculate() {
            int expectedValue = 15;
            int actualValue = combatStat.CalculateMentalDefense(model);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
