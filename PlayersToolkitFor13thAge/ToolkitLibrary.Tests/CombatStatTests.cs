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
        

        [Fact]
        public void CombatStat_ArmorClassShouldCalculate() {
            CharacterModel model = new CharacterModel();
                model.Strength = 13;
                model.Constitution = 16;
                model.Dexterity = 14;
                model.Wisdom = 14;
                model.Intelligence = 13;
                model.Charisma = 19;
                model.CharacterLevel = 3;

            int expectedValue = 15;
            int actualValue = combatStat.CalculateArmorClass(model);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact(Skip = "Test is not yet written")]
        public void CombatStat_PhysicalDefenseShouldCalculate() {

        }

        [Fact(Skip = "Test is not yet written")]
        public void CombatStat_MentalDefenseShouldCalculate() {

        }
    }
}
