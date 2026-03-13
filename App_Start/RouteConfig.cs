using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace BibliotecaMVC.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.Ignore("{resource}.axd/{*pathInfo}");

            routes.MapPageRoute(
                routeName:"RegistrarLibros",
                routeUrl:"vistasBiblioteca/registrar",
                physicalFile:"~/Views/vistasBiblioteca/Registrar.aspx"

                );

            routes.MapPageRoute(
                routeName: "ConsultarLibros",
                routeUrl: "vistasBiblioteca/Consultar",
                physicalFile: "~/Views/vistasBiblioteca/Consultar.aspx"

                );

            routes.MapPageRoute(
                routeName: "VerDetalle",
                routeUrl: "vistasBiblioteca/Detalle",
                physicalFile: "~/Views/vistasBiblioteca/verDetalle.aspx"

                );

            routes.MapPageRoute(
                routeName: "EliminarLibro",
                routeUrl: "vistasBiblioteca/Eliminar",
                physicalFile: "~/Views/vistasBiblioteca/Consultar.aspx"

                );

            routes.MapRoute(
                name: "Default",
                url:"{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );

        }
    }
}
