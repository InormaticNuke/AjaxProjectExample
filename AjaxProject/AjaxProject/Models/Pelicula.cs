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
        public string CantidadEntradas { get; set; }
        public string ValorEntradas { get; set; }
    }
}