using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolkitLibrary
{
    public class CharacterGenerator
    {
        Random rand = new Random();

        public uint generateRandomAbilityStat() {
            uint randomAbilityStat = (uint)rand.Next(5,20);
            return randomAbilityStat;
        }

    }
}
