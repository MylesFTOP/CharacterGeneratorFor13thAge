using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolkitLibrary
{
    public class Dice
    {
        public uint DiceRoll { get; private set; }

        public uint RollDice() {
            Random random = new Random();
            uint diceValue = (uint)random.Next(1, 6);
            return diceValue;
        }
    }
}
