using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblems
{
    public class Pattern
    {
        /// <summary>
        /// This method used to check Validation
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public string ValidateUserEntry(string inputs, string pattern)
        {
            if (Regex.IsMatch(inputs, pattern))
            {
                Console.WriteLine("{0}    => Valid", inputs);
                return "Valid";
            }
            else
            {
                Console.WriteLine("{0}    => Invalid", inputs);
                return "Invalid";
            }
        }
    }
}
