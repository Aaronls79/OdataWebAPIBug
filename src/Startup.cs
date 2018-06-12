using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using OdataWebAPI;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace OdataWebAPI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            var configuration = new HttpConfiguration();

            WebApiConfig.Register(configuration);
           
            app.UseCors(CorsOptions.AllowAll);

            app.UseWebApi(configuration);

        }
    }
}
