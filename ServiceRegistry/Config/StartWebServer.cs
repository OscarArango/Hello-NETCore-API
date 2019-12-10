using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace ServiceRegistry.Config {
    class StartWebServer {
        public static void StartServer() {
            try {
                string domainAddress = "http://localhost:1000";

                using (WebApp.Start(url: domainAddress)) {
                    Console.WriteLine("Service Hosted " + domainAddress);
                    System.Threading.Thread.Sleep(-1);
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}
