using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Exceptions
{
    public class WebException : Exception
    {
        public WebException()
        {
        }

        public WebException(string message)
            : base(message)
        {
        }

        public WebException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
