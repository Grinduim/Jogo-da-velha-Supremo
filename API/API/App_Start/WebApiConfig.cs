using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuração e serviços de API Web
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            // Rotas de API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "Rota de login",
                routeTemplate: "api/login/{email}/{senha}",
                    new
                    {
                        controller =  "User",
                        email = string.Empty,
                        senha = string.Empty,
                    }
                );
            config.Routes.MapHttpRoute(
                name: "Rota de cadastro",
                routeTemplate: "api/cadastro/{email}/{senha}/{nick}",
                    new
                    {
                        controller = "User",
                        email = string.Empty,
                        senha = string.Empty,
                        nick =  string.Empty,
                    }
                );


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
