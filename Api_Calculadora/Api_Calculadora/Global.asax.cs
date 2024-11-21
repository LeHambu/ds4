using System;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Api_Calculadora.App_Start;

namespace Api_Calculadora
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Configuración de Web API
            GlobalConfiguration.Configure(WebApiConfig.Register);

            // Configuración de rutas MVC
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Configurar el formateador JSON para Web API
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);
        }
    }
}