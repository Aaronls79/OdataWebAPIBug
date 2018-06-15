using System.Web.Http;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using OdataWebAPI.Models;

namespace OdataWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            // Web API routes
            config.MapHttpAttributeRoutes();
            
           //OData support
            config.AddODataQueryFilter();
            config.EnableDependencyInjection();

            //ODataConventionModelBuilder builder = new ODataConventionModelBuilder();

            //builder.EnableLowerCamelCase(NameResolverOptions.ProcessReflectedPropertyNames | NameResolverOptions.ProcessExplicitPropertyNames);

            //builder.EntitySet<KISS>("KISS");

            //var edmModel = builder.GetEdmModel();

            //config.MapODataServiceRoute("ODataRoute", "/", edmModel);

            config.Routes.MapHttpRoute(
                "DefaultApi",
                "{controller}/{id}",
                new { id = RouteParameter.Optional }
            );

            config.Count().Filter().OrderBy().Select().MaxTop(2000);
        }
    }
}