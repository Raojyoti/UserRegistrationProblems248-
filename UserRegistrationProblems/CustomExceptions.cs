using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblems
{
    public class CustomExceptions : Exception
    {
        public ExceptionTypes exceptionTypes;
        public enum ExceptionTypes
        {
            EMPTY_INPUT,
            NULL_INPUT,
        }
        public CustomExceptions( string input, ExceptionTypes exception) : base(input)
        {
            this.exceptionTypes = exception;
        }
    }
}
