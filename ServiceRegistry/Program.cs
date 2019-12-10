using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRegistry {
    class Program {
        static void Main(string[] args) {
            try {
                Config.StartWebServer.StartServer();
                //Config.ConnectDB.Connect();
                SampleDBRead.Sample();
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }
    }
}
