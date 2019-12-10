using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ServiceRegistry.Controllers {
    public class ListServicesController : ApiController {

        Models.Service[] Services = new Models.Service[]
        {
            new Models.Service{Id=0,ServiceName="Service1",ServicePort="1000"},
            new Models.Service{Id=1,ServiceName="Service2", ServicePort="1001"},
            new Models.Service{Id=2,ServiceName="Service3",ServicePort="1002"},
            new Models.Service{Id=3,ServiceName="Service4", ServicePort="1003"}
        };

        public IEnumerable<Models.Service> Get() {
            return Services.ToList();
        }

        public Models.Service Get(int Id) {
            try {
                return Services[Id];
            }
            catch (Exception) {
                return new Models.Service();
            }
        }
    }
}
