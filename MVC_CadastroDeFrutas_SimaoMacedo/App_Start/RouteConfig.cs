using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_CadastroDeFrutas_SimaoMacedo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                "sobre",
                "sobre",
                new { controller = "Home", action = "about" }
                );

            routes.MapRoute(
                "contato",
                "contato",
                new { controller = "Home", action = "contact" }
                );

            routes.MapRoute(
                "frutas",
                "frutas",
                new { controller = "Frutas", action = "Index" }
                );

            routes.MapRoute(
                "frutas_novo",
                "frutas/novo",
                new { controller = "Frutas", action = "Novo" }
                );
            routes.MapRoute(
                "frutas_criar",
                "frutas/criar",
                new { controller = "Frutas", action = "Criar" }
                );

            routes.MapRoute(
               "frutas_buscarpornome",
               "frutas/{nome}/buscarpornome",
               new { controller = "Frutas", action = "BuscarPorNome",nome = "" }
               );

            routes.MapRoute(
                "frutas_buscar",
                "frutas/buscar",
                new { controller = "Frutas", action = "Buscar" }
                );

            routes.MapRoute(
                "frutas_editar",
                "frutas/{id}/editar",
                new { controller = "Frutas", action = "Editar", id = 0 }
                );

            routes.MapRoute(
                "frutas_alterar",
                "frutas/{id}/alterar",
                new { controller = "Frutas", action = "Alterar", id = 0 }
                );

            routes.MapRoute(
                "frutas_excluir",
                "frutas/{id}/excluir",
                new { controller = "Frutas", action = "Excluir", id = 0 }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
