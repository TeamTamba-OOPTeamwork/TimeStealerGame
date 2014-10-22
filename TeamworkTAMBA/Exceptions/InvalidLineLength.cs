using System;

namespace TeamworkTAMBA.Exceptions
{
    public class InvalidLineLengthException : Exception
    {
        public InvalidLineLengthException(string message) :
            base(message)
        {
        }
    }
}
