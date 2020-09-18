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
            int diceValue = RollD6();
            if ( diceValue == 1 )
               { diceValue = RollD6(); }
            return diceValue;
        }

        public int RollD4() {
            int diceValue = RollDice(4);
            return diceValue;
        }

        public int RollD6() {
            int diceValue = RollDice(6);
            return diceValue;
        }

        public int RollD8() {
            int diceValue = RollDice(8);
            return diceValue;
        }

        public int RollD10() {
            int diceValue = RollDice(10);
            return diceValue;
        }

        public int RollD12() {
            int diceValue = RollDice(12);
            return diceValue;
        }

        public int RollD20() {
            int diceValue = RollDice(20);
            return diceValue;
        }
    }
}
