using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UT2_09
{
    public class Negocio
    {
        static Biblio bd;
        static Negocio()
        {
            bd = new Biblio();
        }
        public static List<Pelicula> ObtenerPeliculas()
        {
            return bd.Peliculas.ToList();
        }
        public static void CrearPelicula(Pelicula nuevaPelicula)
        {
            int lastId = bd.Peliculas.ToList().Count;
            nuevaPelicula.PeliculasId = lastId;
            bd.Peliculas.Add(nuevaPelicula);
        }
        public static Pelicula ObtenerPelicula(int peliculaId)
        {
            return bd.Peliculas.FirstOrDefault(x => x.PeliculasId == peliculaId);
        }
        public static void BorrarPelicula(int peliculaId)
        {
            var borrar = ObtenerPelicula(peliculaId);
            bd.Peliculas.Remove(borrar);
        }
        public static List<Libro> ObtenerLibros()
        {
            return bd.Libros.ToList();
        }
        public static void CrearLibro(Libro nuevoLibro)
        {
            int lastId = bd.Libros.ToList().Count;
            nuevoLibro.LibrosId = lastId;
            bd.Libros.Add(nuevoLibro);
        }
        public static Libro ObtenerLibro(int libroId)
        {
            return bd.Libros.FirstOrDefault(x => x.LibrosId == libroId);
        }
        public static void BorrarLibro(int libroId)
        {
            var borrar = ObtenerLibro(libroId);
            bd.Libros.Remove(borrar);
        }
    }
}
