using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCine_JulioF
{

    public class Negocio
    {
        private UniCine bd;
        public Negocio()
        {
            bd = new UniCine();
        }

        public Negocio(UniCine bd)
        {
            this.bd = bd;
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            return bd.Peliculas.ToList();
        }

        public bool CrearPelicula(Pelicula nuevaPelicula)
        {
            Pelicula ultimaPelicula = bd.Peliculas.LastOrDefault();
            if (ultimaPelicula == null)
            {
                nuevaPelicula.PeliculaId = 1;
                bd.Peliculas.Add(nuevaPelicula);
                bd.SaveChanges();
                return true;
            }
            nuevaPelicula.PeliculaId = ultimaPelicula.PeliculaId + 1;
            bd.Peliculas.Add(nuevaPelicula);
            bd.SaveChanges();
            return true;
        }

        public Pelicula ObtenerPelicula(int peliculaId)
        {
            return bd.Peliculas.FirstOrDefault(x => x.PeliculaId == peliculaId);
        }

        public bool ModificarPelicula(Pelicula nuevaPelicula)
        {
            Pelicula viejaPelicula = bd.Peliculas.FirstOrDefault(x => x.PeliculaId == nuevaPelicula.PeliculaId);
            if (bd.Proyecciones.Any(p => p.PeliculaId == nuevaPelicula.PeliculaId && DbFunctions.DiffMinutes(bd.Sesiones.FirstOrDefault(s => s.SesionId == p.SesionId).FinMax, bd.Sesiones.FirstOrDefault(s => s.SesionId == p.SesionId).Comienzo) < nuevaPelicula.Duracion))
            {
                throw new UniCineException("No hay tiempo suficiente en las sesiones.");
            }

            bd.Entry(viejaPelicula).CurrentValues.SetValues(nuevaPelicula);
            bd.SaveChanges();
            return true;
        }

        public bool BorrarPelicula(int peliculaId)
        {
            var borrar = bd.Peliculas.FirstOrDefault(x => x.PeliculaId == peliculaId);
            if (bd.Proyecciones.Any(p => p.PeliculaId.Equals(peliculaId)))
            {
                throw new UniCineException("Hay proyecciones que dependen de esta película.");
            }
            bd.Peliculas.Remove(borrar);
            bd.SaveChanges();
            return true;
        }

        public List<Proyeccion> ObtenerProyecciones()
        {
            return bd.Proyecciones.ToList();
        }

        public bool CrearProyeccion(Proyeccion nuevaProyeccion)
        {
            if (nuevaProyeccion.Fin != null)
            {
                if ((nuevaProyeccion.Inicio - nuevaProyeccion.Fin).Value.Days > 0)
                {
                    throw new UniCineException("La fecha de fin no puede ser previa a la de inicio");
                }
            }
            if (DbFunctions.DiffMinutes(bd.Sesiones.FirstOrDefault(s => s.SesionId == nuevaProyeccion.SesionId).FinMax, bd.Sesiones.FirstOrDefault(s => s.SesionId == nuevaProyeccion.SesionId).Comienzo) < bd.Peliculas.FirstOrDefault(x => x.PeliculaId == nuevaProyeccion.PeliculaId).Duracion)
            {
                throw new UniCineException("No hay tiempo suficiente en la sesion para las películas.");
            }
            bd.Proyecciones.Add(nuevaProyeccion);
            bd.SaveChanges();
            return true;
        }

        public Proyeccion ObtenerProyeccion(int sesionId, int peliculaId, DateTime fechaInicio)
        {
            return bd.Proyecciones.FirstOrDefault(x => x.PeliculaId == peliculaId && x.SesionId == sesionId && x.Inicio == fechaInicio);
        }

        public bool ModificarProyeccion(Proyeccion nuevaProyeccion)
        {
            Proyeccion viejaProyeccion = bd.Proyecciones.FirstOrDefault(x => x.PeliculaId == nuevaProyeccion.PeliculaId && x.SesionId == nuevaProyeccion.SesionId && x.Inicio == nuevaProyeccion.Inicio);
            if (nuevaProyeccion.Fin != null)
            {
                if ((nuevaProyeccion.Inicio - nuevaProyeccion.Fin).Value.Days > 0)
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
            return true;
        }

        public bool BorrarProyeccion(int sesionId, int peliculaId, DateTime fechaInicio)
        {
            var borrar = bd.Proyecciones.FirstOrDefault(x => x.PeliculaId == peliculaId && x.SesionId == sesionId && x.Inicio == fechaInicio);
            if (borrar != null)
            {
                bd.Proyecciones.Remove(borrar);
                bd.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Sesion> ObtenerSesiones()
        {
            return bd.Sesiones.ToList();
        }

        public bool CrearSesion(Sesion nuevaSesion)
        {

            Sesion ultimaSesion = bd.Sesiones.LastOrDefault();
            if (ultimaSesion == null)
            {
                nuevaSesion.SesionId = 1;
                bd.Sesiones.Add(nuevaSesion);
                bd.SaveChanges();
                return true;
            }
            nuevaSesion.SesionId = ultimaSesion.SesionId + 1;
            bd.Sesiones.Add(nuevaSesion);
            bd.SaveChanges();
            return true;
        }

        public Sesion ObtenerSesion(int sesionId)
        {
            return bd.Sesiones.FirstOrDefault(x => x.SesionId == sesionId);
        }

        public bool ModificarSesion(Sesion nuevaSesion)
        {
            Sesion viejaSesion = bd.Sesiones.FirstOrDefault(x => x.SesionId == nuevaSesion.SesionId);
            if (viejaSesion != null)
            {
                if (bd.Proyecciones.Any(p => p.SesionId == nuevaSesion.SesionId && DbFunctions.DiffMinutes(nuevaSesion.Comienzo, nuevaSesion.FinMax) < bd.Peliculas.FirstOrDefault(x => x.PeliculaId == p.PeliculaId).Duracion))
                {
                    throw new UniCineException("No hay tiempo suficiente en la sesion para las películas.");
                }
                bd.Entry(viejaSesion).CurrentValues.SetValues(viejaSesion);
                bd.SaveChanges();
                return true;
            }
            return false;
        }

        public bool BorrarSesion(int sesionId)
        {
            var borrar = bd.Sesiones.FirstOrDefault(x => x.SesionId == sesionId);
            if (bd.Proyecciones.Any(p => p.SesionId == sesionId))
            {
                throw new UniCineException("Hay proyecciones que dependen de esta sesión.");
            }
            bd.Sesiones.Remove(borrar);
            bd.SaveChanges();
            return true;
        }
    }
}
