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

        // TODO: remove minimumValue as all implementations call it as 1
        private int RollDice(int minimumValue, int maximumValue) {
            int diceValue = _random.Next(minimumValue, maximumValue);
            return diceValue;
        }

        public int RollAbilityStat() {
            int diceValue = RollD6();
            if ( diceValue == 1 )
               { diceValue = RollD6(); }
            return diceValue;
        }

        public int RollD4() {
            int diceValue = RollDice(1, 4);
            return diceValue;
        }

        public int RollD6() {
            int diceValue = RollDice(1, 6);
            return diceValue;
        }

        public int RollD8() {
            int diceValue = RollDice(1, 8);
            return diceValue;
        }

        public int RollD10() {
            int diceValue = RollDice(1, 10);
            return diceValue;
        }

        public int RollD12() {
            int diceValue = RollDice(1, 12);
            return diceValue;
        }

        public int RollD20() {
            int diceValue = RollDice(1, 20);
            return diceValue;
        }
    }
}
