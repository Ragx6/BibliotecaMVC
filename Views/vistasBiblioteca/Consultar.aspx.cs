using BibliotecaMVC.Controllers;
using BibliotecaMVC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
//Version final
namespace BibliotecaMVC.Views.vistasBiblioteca
{
    public partial class Consultaraspx : System.Web.UI.Page
    {
        private readonly LibroController _controller = new LibroController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                CargarLibros();
            }
            
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
        protected void gvLibros_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Ver")
            {
                GridViewRow fila = gvLibros.Rows[index];

                string codigo = fila.Cells[0].Text;
                string titulo = fila.Cells[1].Text;
                string autor = gvLibros.DataKeys[index]["Autor"].ToString();
                string fecha = gvLibros.DataKeys[index]["FechaPublicacion"].ToString();

                pnlDetalles.Visible = true;
                lblDetalles.Text = $"<strong>Detalles del libro:</strong><br/>" + $"Codigo: {codigo}<br/>" + $"Titulo: {titulo}<br/>" + $"Autor: {autor}<br/>" + $"Fecha: {fecha}";


            }
            else if (e.CommandName == "Eliminar")
            {


                

                string codigo = gvLibros.DataKeys[index].Value.ToString();
                _controller.Eliminar(codigo);
                var librosEncontrados = _controller.ObtenerLibros(txtFiltro.Text.Trim());

                pnlDetalles.Visible= false;
                lblMensaje.Text = null;
                gvLibros.DataSource = librosEncontrados;
                gvLibros.DataBind();

                


            }

        }
    }
    }