using System;

namespace ToolkitLibrary
{
    public class Dice
    {
        readonly Random _random;

        public uint DiceRoll { get; private set; }

        public Dice(Random random) {
            _random = random;
        }

        private uint RollDice(int minimumValue, int maximumValue) {
            uint diceValue = (uint)_random.Next(minimumValue, maximumValue);
            return diceValue;
        }

        public uint RollAbilityStat() {
            uint diceValue = RollD6();
            if ( diceValue == 1 )
               { diceValue = RollD6(); }
            return diceValue;
        }

        public uint RollD4() {
            uint diceValue = RollDice(1, 4);
            return diceValue;
        }

        public uint RollD6() {
            uint diceValue = RollDice(1, 6);
            return diceValue;
        }

        public uint RollD8() {
            uint diceValue = RollDice(1, 8);
            return diceValue;
        }

        public uint RollD10() {
            uint diceValue = RollDice(1, 10);
            return diceValue;
        }

        public uint RollD12() {
            uint diceValue = RollDice(1, 12);
            return diceValue;
        }

        public uint RollD20() {
            uint diceValue = RollDice(1, 20);
            return diceValue;
        }
    }
}
