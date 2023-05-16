using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using UniCine_JulioF;

namespace UniCine_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private Mock<UniCine> _mockUniCineBD;
        private Negocio _negocio;

        [TestInitialize()]
        public void Initialize()
        {
            _mockUniCineBD = new Mock<UniCine>();
            IQueryable<Sesion> datosSesiones = new List<Sesion>
            {   new Sesion{SesionId = 1, Sala = "Sala 1", DiaSemana = "Lunes", Comienzo = DateTime.Parse("3:00 PM"), FinMax = DateTime.Parse("4:00 PM"), Precio = 3.5F, Aforo = 300},
                new Sesion{SesionId = 2, Sala = "Sala 2", DiaSemana = "Martes", Comienzo = DateTime.Parse("10:00 AM"), FinMax = DateTime.Parse("1:00 PM"), Precio = 5F, Aforo = 200},
                new Sesion{SesionId = 3, Sala = "Sala 3", DiaSemana = "Miercoles", Comienzo = DateTime.Parse("1:00AM"), FinMax = DateTime.Parse("5:00 AM"), Precio = 4F, Aforo = 150},
                new Sesion{SesionId = 4, Sala = "Sala 4", DiaSemana = "Jueves", Comienzo = DateTime.Parse("10:00 PM"), FinMax = DateTime.Parse("00:00 AM"), Precio = 2.6F, Aforo = 100}
            }.AsQueryable();

            Mock<DbSet<Sesion>> mockTablaSesiones = new Mock<DbSet<Sesion>>();

            mockTablaSesiones.As<IQueryable<Sesion>>().Setup(x => x.Provider).Returns(datosSesiones.Provider);
            mockTablaSesiones.As<IQueryable<Sesion>>().Setup(x => x.Expression).Returns(datosSesiones.Expression);
            mockTablaSesiones.As<IQueryable<Sesion>>().Setup(x => x.GetEnumerator()).Returns(datosSesiones.GetEnumerator());

            IQueryable<Pelicula> datosPeliculas = new List<Pelicula>
            {
                new Pelicula{ PeliculaId = 1, Nombre = "Pelicula 1", Duracion = 30, Anno = 2022, Categoria = "16", Genero = "Aventura", Sinopsis = "Sinopsis de la pelicula 1"},
                new Pelicula{ PeliculaId = 2, Nombre = "Pelicula 2", Duracion = 300, Anno = 2000, Categoria = "16", Genero = "Romance", Sinopsis = "Sinopsis de la pelicula 2"},
                new Pelicula{ PeliculaId = 3, Nombre = "Pelicula 3", Duracion = 300, Anno = 1950, Categoria = "16", Genero = "Accion", Sinopsis = "Sinopsis de la pelicula 3"},
                new Pelicula{ PeliculaId = 4, Nombre = "Pelicula 4", Duracion = 200, Anno = 2050, Categoria = "16", Genero = "Intanfil", Sinopsis = "Sinopsis de la pelicula 4"}
            }.AsQueryable();
            Mock<DbSet<Pelicula>> mockTablaPeliculas = new Mock<DbSet<Pelicula>>();

            mockTablaPeliculas.As<IQueryable<Pelicula>>().Setup(x => x.Provider).Returns(datosPeliculas.Provider);
            mockTablaPeliculas.As<IQueryable<Pelicula>>().Setup(x => x.Expression).Returns(datosPeliculas.Expression);
            mockTablaPeliculas.As<IQueryable<Pelicula>>().Setup(x => x.GetEnumerator()).Returns(datosPeliculas.GetEnumerator());

            IQueryable<Proyeccion> datosProyeccion = new List<Proyeccion>
            {
                new Proyeccion{ PeliculaId = 1, SesionId = 1, Inicio = DateTime.Today, Fin = null },
                new Proyeccion{ PeliculaId = 3, SesionId = 3, Inicio = DateTime.Today, Fin = null },
                new Proyeccion{ PeliculaId = 4, SesionId = 4, Inicio = DateTime.Today, Fin = null }
            }.AsQueryable();
            Mock<DbSet<Proyeccion>> mockTablaProyecciones = new Mock<DbSet<Proyeccion>>();

            mockTablaProyecciones.As<IQueryable<Proyeccion>>().Setup(x => x.Provider).Returns(datosProyeccion.Provider);
            mockTablaProyecciones.As<IQueryable<Proyeccion>>().Setup(x => x.Expression).Returns(datosProyeccion.Expression);
            mockTablaProyecciones.As<IQueryable<Proyeccion>>().Setup(x => x.GetEnumerator()).Returns(datosProyeccion.GetEnumerator());


            _mockUniCineBD.Setup(x => x.Sesiones).Returns(mockTablaSesiones.Object);
            _mockUniCineBD.Setup(x => x.Peliculas).Returns(mockTablaPeliculas.Object);
            _mockUniCineBD.Setup(x => x.Proyecciones).Returns(mockTablaProyecciones.Object);

            _negocio = new Negocio(_mockUniCineBD.Object);
            Debug.WriteLine("TestInitialize");
        }
        [TestMethod]
        public void ObtenerPeliculas_correcto()
        {
            Pelicula[] peliculas = _negocio.ObtenerPeliculas().ToArray();

            Assert.IsNotNull(peliculas);

            Assert.AreEqual(1, peliculas[0].PeliculaId);
            Assert.AreEqual(2, peliculas[1].PeliculaId);
            Assert.AreEqual(3, peliculas[2].PeliculaId);
            Assert.AreEqual(4, peliculas[3].PeliculaId);
        }

        [TestMethod]
        public void ObtenerPeliculas_incorrecto()
        {
            Pelicula[] peliculas = _negocio.ObtenerPeliculas().ToArray();

            Assert.IsNotNull(peliculas);

            Assert.AreNotEqual(10, peliculas.Length);
            Assert.AreNotEqual(15, peliculas[0].PeliculaId);
            Assert.AreNotEqual(20, peliculas[1].PeliculaId);
            Assert.AreNotEqual(25, peliculas[2].PeliculaId);
            Assert.AreNotEqual(30, peliculas[3].PeliculaId);
        }

        [TestMethod]
        public void ObtenerPeliculas_nulo()
        {
            Pelicula[] peliculas = _negocio.ObtenerPeliculas().ToArray();
            Assert.IsNotNull(peliculas);
            Assert.AreNotEqual(peliculas.Length, 0);
            Assert.IsNotNull(peliculas[0]);
            Assert.IsNotNull(peliculas[1]);
            Assert.IsNotNull(peliculas[2]);
            Assert.IsNotNull(peliculas[3]);
        }

        [TestMethod]
        public void CrearPelicula_correcto()
        {
            Pelicula pelicula = new Pelicula { PeliculaId = 1, Nombre = "Pelicula 1", Duracion = 100, Anno = 2022, Categoria = "16", Genero = "Aventura", Sinopsis = "Sinopsis de la pelicula 1" };

            bool resultado = _negocio.CrearPelicula(pelicula);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void CrearPelicula_nulo()
        {
            try
            {
                Pelicula pelicula = null;

                bool resultado = _negocio.CrearPelicula(pelicula);
                Assert.IsFalse(resultado);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void ObtenerPelicula_correcto()
        {
            Pelicula pelicula = _negocio.ObtenerPelicula(1);
            Assert.IsNotNull(pelicula);
            Assert.AreEqual(1, pelicula.PeliculaId);
        }

        [TestMethod]
        public void ObtenerPelicula_incorrecto()
        {
            Pelicula pelicula = _negocio.ObtenerPelicula(8);
            Assert.IsNull(pelicula);
        }

        [TestMethod]
        public void ObtenerPelicula_nulo()
        {
            Pelicula pelicula = _negocio.ObtenerPelicula(0);
            Assert.IsNull(pelicula);
        }

        [TestMethod]
        public void ModificarPelicula_correcto()
        {
            //Esto da error por el linq pero sin linq no se hacerlo
            Pelicula pelicula = new Pelicula { PeliculaId = 1, Nombre = "Pelicula 3", Duracion = 20, Anno = 2025, Categoria = "32", Genero = "Aventura", Sinopsis = "Sinopsis de la pelicula 1" };
            Assert.IsTrue(_negocio.ModificarPelicula(pelicula));
        }

        [TestMethod]
        public void ModificarPelicula_incorrecto()
        {
            //Esto da error por el linq pero sin linq no se hacerlo
            try
            {
                Pelicula pelicula = new Pelicula { PeliculaId = 1, Nombre = "Pelicula 3", Duracion = 300, Anno = 2022, Categoria = "16", Genero = "Aventura", Sinopsis = "Sinopsis de la pelicula 1" };
                Assert.IsFalse(_negocio.ModificarPelicula(pelicula));
            }
            catch (UniCineException e)
            {
                if (e.Message != "No hay tiempo suficiente en las sesiones.")
                {
                    Assert.Fail(e.Message);
                }
            }
        }

        [TestMethod]
        public void ModificarPelicula_nulo()
        {
            //Esto da error por el linq pero sin linq no se hacerlo
            try
            {
                Pelicula pelicula = null;
                Assert.IsFalse(_negocio.ModificarPelicula(pelicula));
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void BorrarPelicula_correcto()
        {
            Assert.IsTrue(_negocio.BorrarPelicula(2));
        }

        [TestMethod]
        public void BorrarPelicula_incorrecto()
        {
            try
            {
                bool resultado = _negocio.BorrarPelicula(1);

                Assert.IsFalse(resultado);
            }
            catch (UniCineException e)
            {
                if (e.Message != "Hay proyecciones que dependen de esta película.")
                    Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void BorrarPelicula_nulo()
        {
            try
            {
                bool resultado = _negocio.BorrarPelicula(0);
                Assert.IsFalse(resultado);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void ObtenerSesiones_correcto()
        {
            Sesion[] sesiones = _negocio.ObtenerSesiones().ToArray();

            Assert.IsNotNull(sesiones);

            Assert.AreEqual(1, sesiones[0].SesionId);
            Assert.AreEqual(2, sesiones[1].SesionId);
            Assert.AreEqual(3, sesiones[2].SesionId);
            Assert.AreEqual(4, sesiones[3].SesionId);
        }

        [TestMethod]
        public void ObtenerSesiones_incorrecto()
        {
            Sesion[] sesiones = _negocio.ObtenerSesiones().ToArray();

            Assert.IsNotNull(sesiones);

            Assert.AreNotEqual(10, sesiones.Length);
            Assert.AreNotEqual(15, sesiones[0].SesionId);
            Assert.AreNotEqual(20, sesiones[1].SesionId);
            Assert.AreNotEqual(25, sesiones[2].SesionId);
            Assert.AreNotEqual(30, sesiones[3].SesionId);
        }

        [TestMethod]
        public void ObtenerSesiones_nulo()
        {
            Sesion[] sesiones = _negocio.ObtenerSesiones().ToArray();
            Assert.IsNotNull(sesiones);
            Assert.AreNotEqual(sesiones.Length, 0);
            Assert.IsNotNull(sesiones[0]);
            Assert.IsNotNull(sesiones[1]);
            Assert.IsNotNull(sesiones[2]);
            Assert.IsNotNull(sesiones[3]);
        }

        [TestMethod]
        public void CrearSesion_correcto()
        {
            Sesion sesion = new Sesion { SesionId = 1, Sala = "Sala 1", DiaSemana = "Lunes", Comienzo = DateTime.Parse("3:00 PM"), FinMax = DateTime.Parse("6:00 PM"), Precio = 3.5F, Aforo = 300 };

            bool resultado = _negocio.CrearSesion(sesion);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void CrearSesion_nulo()
        {
            try
            {
                Sesion sesion = null;

                bool resultado = _negocio.CrearSesion(sesion);
                Assert.IsFalse(resultado);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void ObtenerSesion_correcto()
        {
            Sesion sesion = _negocio.ObtenerSesion(1);
            Assert.IsNotNull(sesion);
            Assert.AreEqual(1, sesion.SesionId);
        }

        [TestMethod]
        public void ObtenerSesion_incorrecto()
        {
            Sesion sesion = _negocio.ObtenerSesion(8);
            Assert.IsNull(sesion);
        }

        [TestMethod]
        public void ObtenerSesion_nulo()
        {
            Sesion sesion = _negocio.ObtenerSesion(0);
            Assert.IsNull(sesion);
        }

        [TestMethod]
        public void ModificarSesion_correcto()
        {
            //Esto da error por el linq pero sin linq no se hacerlo
            Sesion sesion = new Sesion { SesionId = 1, Sala = "Sala 5", DiaSemana = "Martes", Comienzo = DateTime.Parse("3:00 PM"), FinMax = DateTime.Parse("4:00 PM"), Precio = 3.5F, Aforo = 300 };
            Assert.IsTrue(_negocio.ModificarSesion(sesion));
        }

        [TestMethod]
        public void ModificarSesion_incorrecto()
        {
            //Esto da error por el linq pero sin linq no se hacerlo
            try
            {
                Sesion sesion = new Sesion { SesionId = 3, Sala = "Sala 1", DiaSemana = "Lunes", Comienzo = DateTime.Parse("3:00 PM"), FinMax = DateTime.Parse("4:00 PM"), Precio = 3.5F, Aforo = 300 };
                Assert.IsFalse(_negocio.ModificarSesion(sesion));
            }
            catch (UniCineException e)
            {
                if (e.Message != "No hay tiempo suficiente en la sesion para las películas.")
                {
                    Assert.Fail(e.Message);
                }
            }
        }

        [TestMethod]
        public void ModificarSesion_nulo()
        {
            //Esto da error por el linq pero sin linq no se hacerlo
            try
            {
                Sesion sesion = null;
                Assert.IsFalse(_negocio.ModificarSesion(sesion));
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void BorrarSesion_correcto()
        {
            Assert.IsTrue(_negocio.BorrarPelicula(2));
        }

        [TestMethod]
        public void BorrarSesion_incorrecto()
        {
            try
            {
                bool resultado = _negocio.BorrarSesion(1);

                Assert.IsFalse(resultado);

            }
            catch (UniCineException e)
            {
                if (e.Message != "Hay proyecciones que dependen de esta sesión.")
                    Assert.Fail(e.Message);
            }


        }

        [TestMethod]
        public void BorrarSesion_nulo()
        {
            try
            {
                bool resultado = _negocio.BorrarSesion(-1);
                Assert.IsFalse(resultado);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void ObtenerProyecciones_correcto()
        {
            Proyeccion[] proyecciones = _negocio.ObtenerProyecciones().ToArray();

            Assert.IsNotNull(proyecciones);

            Assert.AreEqual(1, proyecciones[0].SesionId);
            Assert.AreEqual(1, proyecciones[0].PeliculaId);
            Assert.AreEqual(DateTime.Today, proyecciones[0].Inicio);
            Assert.AreEqual(3, proyecciones[1].SesionId);
            Assert.AreEqual(3, proyecciones[1].PeliculaId);
            Assert.AreEqual(DateTime.Today, proyecciones[0].Inicio);
            Assert.AreEqual(4, proyecciones[2].SesionId);
            Assert.AreEqual(4, proyecciones[2].PeliculaId);
            Assert.AreEqual(DateTime.Today, proyecciones[0].Inicio);
        }

        [TestMethod]
        public void ObtenerProyecciones_incorrecto()
        {
            Proyeccion[] proyecciones = _negocio.ObtenerProyecciones().ToArray();

            Assert.IsNotNull(proyecciones);

            Assert.AreNotEqual(10, proyecciones.Length);
            Assert.AreNotEqual(15, proyecciones[0].SesionId);
            Assert.AreNotEqual(15, proyecciones[0].PeliculaId);
            Assert.AreNotEqual(DateTime.MaxValue, proyecciones[0].Inicio);
            Assert.AreNotEqual(20, proyecciones[1].SesionId);
            Assert.AreNotEqual(20, proyecciones[1].PeliculaId);
            Assert.AreNotEqual(DateTime.MaxValue, proyecciones[1].Inicio);
            Assert.AreNotEqual(20, proyecciones[2].SesionId);
            Assert.AreNotEqual(20, proyecciones[2].PeliculaId);
            Assert.AreNotEqual(DateTime.MaxValue, proyecciones[2].Inicio);
        }

        [TestMethod]
        public void ObtenerProyecciones_nulo()
        {
            Proyeccion[] proyecciones = _negocio.ObtenerProyecciones().ToArray();
            Assert.IsNotNull(proyecciones);
            Assert.AreNotEqual(proyecciones.Length, 0);
            Assert.IsNotNull(proyecciones[0]);
            Assert.IsNotNull(proyecciones[1]);
            Assert.IsNotNull(proyecciones[2]);
        }

        [TestMethod]
        public void CrearProyeccion_correcto()
        {
            Proyeccion proyeccion = new Proyeccion { PeliculaId = 1, SesionId = 1, Inicio = DateTime.Today, Fin = null };

            bool resultado = _negocio.CrearProyeccion(proyeccion);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void CrearProyeccion_incorrectoFecha()
        {
            try
            {
                Proyeccion proyeccion = new Proyeccion { PeliculaId = 1, SesionId = 1, Inicio = DateTime.Today, Fin = DateTime.MinValue };

                bool resultado = _negocio.CrearProyeccion(proyeccion);
                Assert.IsFalse(resultado);
            }
            catch (UniCineException e)
            {
                if (e.Message != "La fecha de fin no puede ser previa a la de inicio")
                {
                    Assert.Fail(e.Message);
                }
            }

        }

        [TestMethod]
        public void CrearProyeccion_incorrectoDuracion()
        {
            try
            {
                Proyeccion proyeccion = new Proyeccion { PeliculaId = 2, SesionId = 1, Inicio = DateTime.Today, Fin = null };

                bool resultado = _negocio.CrearProyeccion(proyeccion);
                Assert.IsTrue(resultado);
            }
            catch (UniCineException e)
            {
                if (e.Message != "No hay tiempo suficiente en la sesion para las películas.")
                {
                    Assert.Fail(e.Message);
                }
            }

        }

        [TestMethod]
        public void CrearProyeccion_nulo()
        {
            try
            {
                Proyeccion proyeccion = null;

                bool resultado = _negocio.CrearProyeccion(proyeccion);
                Assert.IsFalse(resultado);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void ObtenerProyeccion_correcto()
        {
            Proyeccion proyeccion = _negocio.ObtenerProyeccion(1, 1, DateTime.Today);
            Assert.IsNotNull(proyeccion);
            Assert.AreEqual(1, proyeccion.SesionId);
            Assert.AreEqual(1, proyeccion.PeliculaId);
            Assert.AreEqual(DateTime.Today, proyeccion.Inicio);
        }

        [TestMethod]
        public void ObtenerProyeccion_incorrecto()
        {
            Proyeccion proyeccion = _negocio.ObtenerProyeccion(12, 31, DateTime.MinValue);
            Assert.IsNull(proyeccion);
        }

        [TestMethod]
        public void ObtenerProyeccion_nulo()
        {
            Proyeccion proyeccion = _negocio.ObtenerProyeccion(12, 31, DateTime.MinValue);
            Assert.IsNull(proyeccion);
        }

        [TestMethod]
        public void ModificarProyeccion_correcto()
        {
            Proyeccion proyeccion = new Proyeccion { PeliculaId = 1, SesionId = 2, Inicio = DateTime.Today, Fin = null };

            bool resultado = _negocio.ModificarProyeccion(proyeccion);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void ModificarProyeccion_incorrectoFecha()
        {
            try
            {
                Proyeccion proyeccion = new Proyeccion { PeliculaId = 1, SesionId = 1, Inicio = DateTime.Today, Fin = DateTime.MinValue };

                bool resultado = _negocio.ModificarProyeccion(proyeccion);
                Assert.IsFalse(resultado);
            }
            catch (UniCineException e)
            {
                if (e.Message != "La fecha de fin no puede ser previa a la de inicio")
                {
                    Assert.Fail(e.Message);
                }
            }

        }

        [TestMethod]
        public void ModificarProyeccion_incorrectoDuracion()
        {
            try
            {
                Proyeccion proyeccion = new Proyeccion { PeliculaId = 2, SesionId = 1, Inicio = DateTime.Today, Fin = null };

                bool resultado = _negocio.ModificarProyeccion(proyeccion);
                Assert.IsTrue(resultado);
            }
            catch (UniCineException e)
            {
                if (e.Message != "No hay tiempo suficiente en la sesion para la películas.")
                {
                    Assert.Fail(e.Message);
                }
            }

        }

        [TestMethod]
        public void ModificarProyeccion_nulo()
        {
            try
            {
                Proyeccion proyeccion = null;

                bool resultado = _negocio.ModificarProyeccion(proyeccion);
                Assert.IsFalse(resultado);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void BorrarProyeccion_correcto()
        {
            Assert.IsTrue(_negocio.BorrarProyeccion(1,1,DateTime.Today));
        }
        [TestMethod]
        public void BorrarProyeccion_nulo()
        {
            try
            {
                bool resultado = _negocio.BorrarProyeccion(0, 0, DateTime.MinValue);
                Assert.IsFalse(resultado);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }








        [TestCleanup]
        public void TestCleanup()
        {

        }
    }
}
