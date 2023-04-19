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

        public static List<Pelicula> obtenerPeliculas()
        {
            return bd.Peliculas.ToList();
        }

        public static void CrearPelicula(Pelicula nuevaPelicula)
        {
            int ultimoId = bd.Peliculas.ToList().Count;
            nuevaPelicula.PeliculaId = ultimoId;
            bd.Peliculas.Add(nuevaPelicula);
            bd.SaveChanges();
        }

        public static Pelicula obtenerPelicula(int peliculaId)
        {
            return bd.Peliculas.FirstOrDefault(x =>  x.PeliculaId == peliculaId);
        }

        public static void ModificarPelicula(Pelicula nuevaPelicula)
        {
            Pelicula viejaPelicula = bd.Peliculas.FirstOrDefault(x => x.PeliculaId == nuevaPelicula.PeliculaId);
            if (viejaPelicula != null)
            {
                bd.Entry(viejaPelicula).CurrentValues.SetValues(nuevaPelicula);
                bd.SaveChanges();
            }
        }
        public static void BorrarPelicula(int peliculaId)
        {
            var borrar = bd.Peliculas.FirstOrDefault(x => x.PeliculaId == peliculaId);
            bd.Peliculas.Remove(borrar);
            bd.SaveChanges();
        }

        public static List<Proyeccion> ObenerProyecciones()
        {
            return bd.Proyecciones.ToList();
        }

        public static void CrearProyeccion(Proyeccion nuevaProyeccion)
        {
            
            bd.Proyecciones.Add(nuevaProyeccion);
            bd.SaveChanges();
        }

        public static Proyeccion ObtenerProyeccion(int peliculaId,int sesionId,DateTime fechaInicio)
        {
            return bd.Proyecciones.FirstOrDefault(x => x.PeliculaId == peliculaId && x.SesionId == sesionId && x.Inicio == fechaInicio);
        }

        public static void ModificarProyeccion(Proyeccion nuevaProyeccion)
        {
            Proyeccion viejaProyeccion = bd.Proyecciones.FirstOrDefault(x => x.PeliculaId == nuevaProyeccion.PeliculaId && x.SesionId == nuevaProyeccion.SesionId && x.Inicio == nuevaProyeccion.Inicio);
            if (viejaProyeccion != null)
            {
                bd.Entry(viejaProyeccion).CurrentValues.SetValues(viejaProyeccion);
                bd.SaveChanges();
            }
        }

        public static void BorrarProyeccion(int peliculaId, int sesionId, DateTime fechaInicio)
        {
            var borrar = bd.Proyecciones.FirstOrDefault(x => x.PeliculaId == peliculaId && x.SesionId == sesionId && x.Inicio == fechaInicio);
            bd.Proyecciones.Remove(borrar);
            bd.SaveChanges();
        }

        public static List<Sesion> ObtenerSesiones()
        {
            return bd.Sesiones.ToList();
        }

        public static void CrearSesion(Sesion nuevaSesion)
        {

            bd.Sesiones.Add(nuevaSesion);
            bd.SaveChanges();
        }

        public static Sesion ObtenerSesion(int sesionId)
        {
            return bd.Sesiones.FirstOrDefault(x => x.SesionId == sesionId);
        }

        public static void ModificarSesion(Sesion nuevaSesion)
        {
            Sesion viejaSesion = bd.Sesiones.FirstOrDefault(x => x.SesionId == nuevaSesion.SesionId);
            if (viejaSesion != null)
            {
                bd.Entry(viejaSesion).CurrentValues.SetValues(viejaSesion);
                bd.SaveChanges();
            }
        }
        public static void BorrarSesion(int sesionId)
        {
            var borrar = bd.Sesiones.FirstOrDefault(x => x.SesionId == sesionId);
            bd.Sesiones.Remove(borrar);
            bd.SaveChanges();
        }
    }
}
