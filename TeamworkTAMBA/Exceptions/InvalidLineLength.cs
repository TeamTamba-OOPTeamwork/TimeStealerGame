using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkTAMBA.Exceptions
{
    using System.Windows.Forms;

    public class InvalidLineLengthException : Exception
    {
        public InvalidLineLengthException(string message) :
            base(message)
        {
        }
    }
}
