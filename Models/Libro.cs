using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaMVC.Models
{
    public class Libro
    {
        int codigo {  get; set; }

        string titulo { get; set; }

        string autor {  get; set; }

        DateTime fechaPublicacion { get; set; }
    }
}