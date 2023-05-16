using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCine_JulioF
{
    public class UniCineException : ApplicationException
    {
        public UniCineException() : base() { }
        public UniCineException(string message) : base(message) { }
        public UniCineException(string message, Exception inner) : base(message, inner) { }
    }
}
