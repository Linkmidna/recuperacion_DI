using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Julio_F_Higuera
{
    static public class Herramientas
    {
        static public Empresa ObtenerEmpresa(int? empresaId)
        {
            if (empresaId == null) return null;
            PracticasBD bd = new PracticasBD();
            return bd.Empresas.FirstOrDefault(e => e.EmpresaId == empresaId);
        }

        static public Empresa ObtenerEmpresa(string nif)
        {
            PracticasBD bd = new PracticasBD();
            return bd.Empresas.FirstOrDefault(e => e.NIF == nif);
        }

        static public Empresa[] ObtenerEmpresas(string filtro)
        {
            PracticasBD bd = new PracticasBD();
            return bd.Empresas.Where(e => e.Nombre.Contains(filtro)).ToArray();
        }

        static public string ObtenerNombreEmpresa(int? empresaId)
        {
            if (empresaId == null) return null;
            PracticasBD bd = new PracticasBD();
            return bd.Empresas.FirstOrDefault(e => e.EmpresaId == empresaId).Nombre;
        }
    }
}
