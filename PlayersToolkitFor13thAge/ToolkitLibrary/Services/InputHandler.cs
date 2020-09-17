using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolkitLibrary
{
    public static class InputHandler
    {
        public static bool ValidateValueAsInt(string stringInput, out int result) {
            bool output = int.TryParse(stringInput, out result);
            return output;
        }

        public static bool ValidateNonNegativeInt(string stringInput, out int result) {
            bool output = ValidateValueAsInt(stringInput, out result);

            if (result < 0)
            {
                result = 0;
                output = false;
            }
            return output;
        }
        
        public static bool ValidateValueAsUint(string stringInput, out uint result) {
            bool output = uint.TryParse(stringInput, out result);
            return output;
        }
    }
}
