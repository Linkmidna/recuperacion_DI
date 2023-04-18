using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCine_JulioF
{

    public class Negocio
    {
        private static UniCine bd;
        static Negocio()
        {
            bd = new UniCine();
        }
    }
}
