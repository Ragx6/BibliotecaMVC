using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaMVC.Models
{
    public class Libro
    {
        public string Codigo {  get; set; }

        public string Titulo { get; set; }

        public string Autor {  get; set; }

        public DateTime FechaPublicacion { get; set; }
    }
}