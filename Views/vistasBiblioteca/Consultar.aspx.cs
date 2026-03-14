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
    public partial class Consultaraspx : System.Web.UI.Page
    {
        private readonly LibroController _controller = new LibroController();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarLibros();
        }

        private void CargarLibros(string filtroCodigo = null) 
        {
            var lista = _controller.ObtenerLibros(filtroCodigo);

            gvLibros.DataSource = lista;
            gvLibros.DataBind();
        }

        protected void btnRefrescar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = null;
            txtFiltro.Text = string.Empty;
            CargarLibros();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = null;
            try
            {
                var librosEncontrados = _controller.ObtenerLibros(txtFiltro.Text.Trim());
                gvLibros.DataSource = librosEncontrados;
                gvLibros.DataBind();


                lblMensaje.Text = "Libro encontrado";
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;

                lblMensaje.ForeColor = System.Drawing.Color.Red;

                gvLibros.DataSource = null;
                gvLibros.DataBind();
            }

            
        }
    }
}