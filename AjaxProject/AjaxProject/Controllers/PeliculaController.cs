using AjaxProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxProject.Controllers
{
    public class PeliculaController : Controller
    {
        // GET: Pelicula
        public ActionResult Index()
        {
            return View();
        }

        private Pelicula[] peliculas;

        public PeliculaController()
        {

            peliculas = new Pelicula[]
            {
                new Pelicula
                {
                    IdPelicula = "100",
                    NombrePelicula = "John Wick",
                    CategoriaPelicula = "Accion",
                    CantidadEntradas = 1,
                    ValorEntradas = 4500
                },

                new Pelicula
                {
                    IdPelicula = "200",
                    NombrePelicula = "El señor de los anillos",
                    CategoriaPelicula = "Ficcion",
                    CantidadEntradas = 4,
                    ValorEntradas = 5000
                },

                new Pelicula
                {
                    IdPelicula = "300",
                    NombrePelicula = "Alien",
                    CategoriaPelicula = "Ciencia Ficcion",
                    CantidadEntradas = 2,
                    ValorEntradas = 3500
                }

            };

        }
    }
}