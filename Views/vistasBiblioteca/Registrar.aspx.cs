using BibliotecaMVC.Controllers;
using BibliotecaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaMVC.Views.vistasBiblioteca
{
    public partial class Registrar : System.Web.UI.Page
    {
        public readonly LibroController _controller = new LibroController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try 
            {
                var libro = new Libro
                {
                    Codigo = txtCodigo.Text.Trim(),
                    Autor = txtAutor.Text.Trim(),
                    Titulo = txtTitulo.Text.Trim(),
                    FechaPublicacion = DateTime.Parse(txtFecha.Text.Trim())
                };



                _controller.Registrar(libro);

                lblMensaje.Text = "Libro registrado correctamente";
                lblMensaje.ForeColor = System.Drawing.Color.Green;

                txtCodigo.Text = txtTitulo.Text = txtAutor.Text = txtFecha.Text = null;
            }

            catch (FormatException) 
            {
                lblMensaje.Text = "Error: La fecha ingresada no es valida, recuerda usar el formato YYYY-MM-DD";

                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
           

            catch(Exception ex) 
            {
                lblMensaje.Text = "Error: " + ex.Message;

                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}