using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Julio_F_Higuera
{
    internal class PracticasException : ApplicationException
    {
        public PracticasException() : base() { }
        public PracticasException(string message) : base(message) { }
        public PracticasException(string message, Exception inner) : base(message, inner) { }
    }
}
