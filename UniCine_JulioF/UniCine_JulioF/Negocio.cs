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
        private  UniCine bd;
         public Negocio()
        {
            bd = new UniCine();
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            return bd.Peliculas.ToList();
        }

        public void CrearPelicula(Pelicula nuevaPelicula)
        {
            int ultimoId = bd.Peliculas.ToList().Count;
            nuevaPelicula.PeliculaId = ultimoId;
            bd.Peliculas.Add(nuevaPelicula);
            bd.SaveChanges();
        }

        public Pelicula ObtenerPelicula(int peliculaId)
        {
            return bd.Peliculas.FirstOrDefault(x =>  x.PeliculaId == peliculaId);
        }

        public void ModificarPelicula(Pelicula nuevaPelicula)
        {
            Pelicula viejaPelicula = bd.Peliculas.FirstOrDefault(x => x.PeliculaId == nuevaPelicula.PeliculaId);
            if (viejaPelicula != null)
            {
                List<Proyeccion> proyecciones = bd.Proyecciones.Where(p => p.PeliculaId.Equals(viejaPelicula.PeliculaId)).ToList();
                List<Sesion> sesiones = new List<Sesion>();
                foreach (Proyeccion p in proyecciones)
                {
                    sesiones.Add(bd.Sesiones.FirstOrDefault(x => x.SesionId == p.SesionId));
                }
                foreach (Sesion s in sesiones)
                {
                    if (s.FinMax.Subtract(s.Comienzo).Minutes < nuevaPelicula.Duracion)
                    {
                        throw new UniCineException("No hay tiempo suficiente en las sesiones.");
                    }
                }
                bd.Entry(viejaPelicula).CurrentValues.SetValues(nuevaPelicula);
                bd.SaveChanges();
            }
        }
        public void BorrarPelicula(int peliculaId)
        {
            var borrar = bd.Peliculas.FirstOrDefault(x => x.PeliculaId == peliculaId);
            if (bd.Proyecciones.Where(p => p.PeliculaId.Equals(peliculaId)).ToList().Count >0 )
            {
                throw new UniCineException("La película tiene proyecciones asociadas");
            }
            bd.Peliculas.Remove(borrar);
            bd.SaveChanges();
        }

        public List<Proyeccion> ObenerProyecciones()
        {
            return bd.Proyecciones.ToList();
        }

        public void CrearProyeccion(Proyeccion nuevaProyeccion)
        {
            if (nuevaProyeccion.Fin !=null)
            {
                if (nuevaProyeccion.Inicio.CompareTo(nuevaProyeccion.Fin) == 1)
                {
                    throw new UniCineException("La fecha de fin no puede ser previa a la de inicio");
                }
            }
            bd.Proyecciones.Add(nuevaProyeccion);
            bd.SaveChanges();
        }

        public Proyeccion ObtenerProyeccion(int sesionId, int peliculaId, DateTime fechaInicio)
        {
            return bd.Proyecciones.FirstOrDefault(x => x.PeliculaId == peliculaId && x.SesionId == sesionId && x.Inicio == fechaInicio);
        }

        public void ModificarProyeccion(Proyeccion nuevaProyeccion)
        {
            Proyeccion viejaProyeccion = bd.Proyecciones.FirstOrDefault(x => x.PeliculaId == nuevaProyeccion.PeliculaId && x.SesionId == nuevaProyeccion.SesionId && x.Inicio == nuevaProyeccion.Inicio);
            if (viejaProyeccion != null)
            {
                if (nuevaProyeccion.Fin != null)
                {
                    if (nuevaProyeccion.Inicio.CompareTo(nuevaProyeccion.Fin) == 1)
                    {
                        throw new UniCineException("La fecha de fin no puede ser previa a la de inicio");
                    }
                }
                Sesion sesion = bd.Sesiones.FirstOrDefault(x => x.SesionId == nuevaProyeccion.SesionId);
                Pelicula pelicula = bd.Peliculas.FirstOrDefault(x => x.PeliculaId == nuevaProyeccion.PeliculaId);
                if (sesion.FinMax.Subtract(sesion.Comienzo).Minutes < pelicula.Duracion)
                    {
                        throw new UniCineException("No hay tiempo suficiente en la sesion para la películas.");
                    }
                bd.Entry(viejaProyeccion).CurrentValues.SetValues(viejaProyeccion);
                bd.SaveChanges();
            }
        }

        public void BorrarProyeccion(int sesionId, int peliculaId, DateTime fechaInicio)
        {
            var borrar = bd.Proyecciones.FirstOrDefault(x => x.PeliculaId == peliculaId && x.SesionId == sesionId && x.Inicio == fechaInicio);
            bd.Proyecciones.Remove(borrar);
            bd.SaveChanges();
        }

        public List<Sesion> ObtenerSesiones()
        {
            return bd.Sesiones.ToList();
        }

        public void CrearSesion(Sesion nuevaSesion)
        {

            bd.Sesiones.Add(nuevaSesion);
            bd.SaveChanges();
        }

        public Sesion ObtenerSesion(int sesionId)
        {
            return bd.Sesiones.FirstOrDefault(x => x.SesionId == sesionId);
        }

        public void ModificarSesion(Sesion nuevaSesion)
        {
            Sesion viejaSesion = bd.Sesiones.FirstOrDefault(x => x.SesionId == nuevaSesion.SesionId);
            if (viejaSesion != null)
            {
                List<Proyeccion> proyecciones = bd.Proyecciones.Where(p => p.PeliculaId.Equals(viejaSesion.SesionId)).ToList();
                List<Pelicula> peliculas = new List<Pelicula>();
                foreach (Proyeccion p in proyecciones)
                {
                    peliculas.Add(bd.Peliculas.FirstOrDefault(x => x.PeliculaId == p.PeliculaId));
                }
                foreach (Pelicula p in peliculas)
                {
                    if (nuevaSesion.FinMax.Subtract(nuevaSesion.Comienzo).Minutes < p.Duracion)
                    {
                        throw new UniCineException("No hay tiempo suficiente en la sesion para las películas.");
                    }
                }
                bd.Entry(viejaSesion).CurrentValues.SetValues(viejaSesion);
                bd.SaveChanges();
            }
        }
        public void BorrarSesion(int sesionId)
        {
            var borrar = bd.Sesiones.FirstOrDefault(x => x.SesionId == sesionId);
            bd.Sesiones.Remove(borrar);
            bd.SaveChanges();
        }
    }
}
