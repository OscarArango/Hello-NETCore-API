using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRegistry.Models {
    public class Service {
        public int Id {
            get; set;
        }
        public string ServiceName {
            get; set;
        }
        public string ServicePort {
            get; set;
        }
    }
}
