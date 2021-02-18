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

        private readonly CharacterModel m = new CharacterModel(
            characterName: "Test name", characterClass: "Test class", characterRace: "Test race", characterLevel: "3",
            strength: "13", constitution: "16", dexterity: "14", intelligence: "14", wisdom: "13", charisma: "19",
            currentHitPoints: "21"
            );

        [Fact]
        public void CombatStat_ArmorClassShouldCalculate() {
            int expectedValue = 15;
            int actualValue = combatStat.CalculateArmorClass(m.Constitution, m.Dexterity, m.Wisdom, m.CharacterLevel);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void CombatStat_PhysicalDefenseShouldCalculate() {
            int expectedValue = 16;
            int actualValue = combatStat.CalculatePhysicalDefense(m.Strength, m.Constitution, m.Dexterity, m.CharacterLevel);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void CombatStat_MentalDefenseShouldCalculate() {
            int expectedValue = 15;
            int actualValue = combatStat.CalculateMentalDefense(m.Intelligence, m.Wisdom, m.Charisma, m.CharacterLevel);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
