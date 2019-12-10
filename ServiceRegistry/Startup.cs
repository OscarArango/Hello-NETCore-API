using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owin;
using System.Web.Http;
using System.Net.Http;

namespace ServiceRegistry {
    public class Startup {
        public void Configuration(IAppBuilder appBuilder) {
            HttpConfiguration CONFIG = new HttpConfiguration();
            CONFIG.EnableCors();
            CONFIG.Routes.MapHttpRoute(
                name: "createUserApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new {
                    id = RouteParameter.Optional
                }
                );
            appBuilder.UseWebApi(CONFIG);
        }
    }
}
