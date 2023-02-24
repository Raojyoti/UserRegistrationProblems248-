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
        /// UC12.1-Check validations for First Name and Last Name
        /// UC12.2-Check validations for Email Id
        /// UC12.3-Check validations for Phone Number
        /// UC12.4-Check validations for Password
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        /// <exception cref="CustomExceptions"></exception>
        public string ValidateUserDetails(string inputs, string pattern)
        {
            try
            {
                if (inputs.Equals(string.Empty))
                {
                    Console.WriteLine("Given input \"Empty\" then\nthrow CustomExceptions");
                    throw new CustomExceptions("Input is having empty", CustomExceptions.ExceptionTypes.EMPTY_INPUT);
                }
                else if (Regex.IsMatch(inputs, pattern))
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
            catch(NullReferenceException)
            {
                Console.WriteLine("Given input \"null\" then\nthrow CustomExceptions");
                throw new CustomExceptions("Input is having null", CustomExceptions.ExceptionTypes.NULL_INPUT);
            }   
        }
    }
}
