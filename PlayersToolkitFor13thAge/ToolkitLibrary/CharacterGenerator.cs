using System;

namespace ToolkitLibrary
{
    public class CharacterGenerator
    {
        readonly Random rand = new Random();

        public uint GenerateRandomAbilityStat() {
            // TODO: Change to use Dice.RollAbilityStat() 4 times and drop the lowest
            uint randomAbilityStat = (uint)rand.Next(5,20);
            return randomAbilityStat;
        }

    }
}
