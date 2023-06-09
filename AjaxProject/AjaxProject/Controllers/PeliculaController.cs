using AjaxProject.Models;
using Newtonsoft.Json;
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

            peliculas = new Boleta[]
            {
                new Boleta
                {
                    IdPelicula = "100",
                    NombrePelicula = "John Wick",
                    CategoriaPelicula = "Accion",
                    claseEntradas = new Entradas{
                    CantidadEntradas = 1,
                    ValorEntradas = 4500
                    }
                },

                new Boleta
                {
                    IdPelicula = "200",
                    NombrePelicula = "El señor de los anillos",
                    CategoriaPelicula = "Ficcion",
                    claseEntradas = new Entradas{
                    CantidadEntradas = 4,
                    ValorEntradas = 5000
                    }
                },

                new Boleta
                {
                    IdPelicula = "300",
                    NombrePelicula = "Alien",
                    CategoriaPelicula = "Ciencia Ficcion",
                    claseEntradas = new Entradas{
                    CantidadEntradas = 2,
                    ValorEntradas = 3500
                    }
                }

            };

        }

        public string ObtenerPeliculasJson()
        {
            return JsonConvert.SerializeObject(peliculas);
        }

    }
}