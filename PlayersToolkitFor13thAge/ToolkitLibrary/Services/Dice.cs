using System;

namespace ToolkitLibrary
{
    public class Dice
    {
        readonly Random _random;

        public int DiceRoll { get; private set; }

        public Dice(Random random) {
            _random = random;
        }

        private int RollDice(int maximumValue) {
            int diceValue = _random.Next(1, maximumValue);
            return diceValue;
        }

        public int RollAbilityStat() {
            int diceValue = RollDice(6);
            if ( diceValue == 1 )
               { diceValue = RollDice(6); }
            return diceValue;
        }
    }
}
