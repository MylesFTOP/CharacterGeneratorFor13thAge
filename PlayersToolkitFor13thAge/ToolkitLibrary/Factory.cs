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
    }
}
