using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolkitLibrary
{
    public static class Factory
    {
        public static Dice CreateDice() {
            return new Dice(CreateRandom());
        }
        public static Random CreateRandom() {
            return new Random();
        }

        public static CharacterModel CreateCharacterModel() {
            return new CharacterModel();
        }

        public static AbilityStat CreateAbilityStat() {
            return new AbilityStat();
        }

        public static CombatStat CreateCombatStat() {
            return new CombatStat();
        }

        public static SQLConnector CreateSqlConnector() {
            return new SQLConnector();
        }

        public static TextConnector CreateTextConnector() {
            return new TextConnector();
        }
    }
}
