using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxProject.Models
{
    public class Pelicula
    {
        public string IdPelicula { get; set; }
        public string NombrePelicula { get; set; }
        public string CategoriaPelicula { get; set; }
        public int CantidadEntradas { get; set; }
        public int ValorEntradas { get; set; }
    }
}