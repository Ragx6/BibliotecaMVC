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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRefrescar_Click(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }
        protected void gvLibros_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
            if (e.CommandName == "Seleccionar")
            {
                
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow fila = gvLibros.Rows[index];

               
                string codigo = fila.Cells[0].Text;
                
            }
        }


    }
}