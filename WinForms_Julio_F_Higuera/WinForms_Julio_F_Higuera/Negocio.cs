using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Julio_F_Higuera
{
    internal class Negocio
    {
        public Empresa[] BuscarEmpresas()
        {
            PracticasBD bd = new PracticasBD();
            return bd.Empresas.ToArray();
        }

        public void Crear(Empresa nuevaEmpresa)
        {
            PracticasBD bd = new PracticasBD();
            bd.Empresas.Add(nuevaEmpresa);
            bd.SaveChanges();
        }

        public void Actualizar(Empresa empresa)
        {
            PracticasBD bd = new PracticasBD();            
            Empresa aux = bd.Empresas.FirstOrDefault(x => x.EmpresaId == empresa.EmpresaId);
            if (aux != null)
            {
                bd.Entry(aux).CurrentValues.SetValues(empresa);
                bd.SaveChanges();
            }
        }

        public void Borrar(Empresa empresaBorrar)
        {
            PracticasBD bd = new PracticasBD();
            Empresa aux = bd.Empresas.FirstOrDefault(x => x.EmpresaId == empresaBorrar.EmpresaId);
            if (aux != null)
            {
                if(bd.Alumnos.Any(x=> x.EmpresaId == empresaBorrar.EmpresaId))
                {
                    throw new PracticasException("Antes de eliminar la empresa debe eliminar los alumnos asociados");
                }

                bd.Empresas.Remove(aux);
                bd.SaveChanges();
            }
        }

        public Alumno[] BuscarAlumnos()
        {
            PracticasBD bd = new PracticasBD();
            return bd.Alumnos.ToArray();
        }

        public void Crear(Alumno nuevoAlumno)
        {
            PracticasBD bd = new PracticasBD();
            bd.Alumnos.Add(nuevoAlumno);
            bd.SaveChanges();
        }

        public void Actualizar(Alumno alumno)
        {
            PracticasBD bd = new PracticasBD();
            Alumno aux = bd.Alumnos.FirstOrDefault(x => x.AlumnoId == alumno.AlumnoId);
            if (aux != null)
            {
                bd.Entry(aux).CurrentValues.SetValues(alumno);
                bd.SaveChanges();
            }
        }

        public void Borrar(Alumno alumnoBorrar)
        {
            PracticasBD bd = new PracticasBD();
            Alumno aux = bd.Alumnos.FirstOrDefault(x => x.AlumnoId == alumnoBorrar.AlumnoId);
            if (aux != null)
            {
                bd.Alumnos.Remove(aux);
                bd.SaveChanges();
            }
        }
    }
}
