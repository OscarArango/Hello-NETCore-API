using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ServiceRegistry.Config {
    public static class ConnectDB {
        public static SqlConnection Connect() {
            try {
                //var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                //var cnn = new SqlConnection(connectionString);

                //return cnn;

                //Short Hand version of the code above.
                return new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
