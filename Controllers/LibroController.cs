using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Profile;
using BibliotecaMVC.Models;

namespace BibliotecaMVC.Controllers
{
    public class LibroController
    {
        private static readonly List<Libro> _Libros = new List<Libro>();

        public void Registrar(Libro nuevo) 
        {
            if (string.IsNullOrWhiteSpace(nuevo.Codigo)) 
            {
                throw new ArgumentException("El codigo del libro no puede estar vacio");
            }

            if (string.IsNullOrEmpty(nuevo.Titulo)) 
            {
                throw new ArgumentException("El titulo del libro no puede estar vacio");
            }

            if (string.IsNullOrEmpty(nuevo.FechaPublicacion.ToString())) 
            {
                throw new ArgumentException("La fecha del libro no puede estar vacio");
            }

            string titulopegado = nuevo.Titulo.Replace(" ", "").ToUpper();

            bool yaExisteTitulo = _Libros.Any(a => a.Titulo.Replace(" ", "").ToUpper() == titulopegado);

            if (yaExisteTitulo) 
            {
                throw new InvalidOperationException("Ya existe un libro con ese titulo");
            }

            bool yaExisteCodigo = _Libros.Any(a => a.Codigo.Equals(nuevo.Codigo.Replace(" ","").ToUpper(), StringComparison.OrdinalIgnoreCase));

            if (yaExisteCodigo)
            {
                throw new InvalidOperationException("Ya existe un libro con ese codigo");
            }

            _Libros.Add(nuevo);
        }

        public List<Libro> ObtenerLibros(String buscar = null) 
        {
            if (string.IsNullOrWhiteSpace(buscar)) 
            {
                return _Libros;
            }

            string titulopegado = buscar.Replace(" ","").ToUpper();

            var encontrado = _Libros.Where(m => m.Codigo.Replace(" ", "").ToUpper().Contains(buscar) || m.Titulo.Replace(" ", "").ToUpper().Contains(buscar)).ToList();

            if (!encontrado.Any()) 
            {
                throw new InvalidOperationException("No se encontro ningun libro con ese codigo o titulo");
            }

            return encontrado;
        }

        public void Eliminar(string codigo) 
        {
            var encontrado = _Libros.FirstOrDefault(m => m.Codigo.Trim().ToUpper() == codigo.Trim().ToUpper());

            if (encontrado != null) 
            {
                _Libros.Remove(encontrado);
            }

            else 
            {
                throw new Exception("No se encontro un libro para poder eliminar");
            }
            
        }

    }
}