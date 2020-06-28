using System;

namespace ToolkitLibrary
{
    public class CharacterGenerator
    {
        readonly Random rand = new Random();

        public uint GenerateRandomAbilityStat() {
            uint randomAbilityStat = (uint)rand.Next(5,20);
            return randomAbilityStat;
        }

    }
}
