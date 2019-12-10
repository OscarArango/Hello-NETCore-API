using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ServiceRegistry {
    public static class SampleDBRead {
        public static bool Sample() {
            var con = Config.ConnectDB.Connect();

            try {
                con.Open();
                Console.WriteLine("Connection Open !\n");

                // create a SqlCommand object for this connection
                SqlCommand command = con.CreateCommand();
                command.CommandText = "Select * from Ports";
                command.CommandType = CommandType.Text;

                // execute the command that returns a SqlDataReader
                SqlDataReader reader = command.ExecuteReader();

                // display the results
                while (reader.Read()) {
                    //whatever you want to do.
                    Console.WriteLine("Services currently running: " + reader["ServiceName"] + "On Port#: " + reader["ServicePort"]);

                }

                Console.ReadLine();

                // close the connection
                reader.Close();
                con.Close();

            }
            catch (Exception ex) {
                Console.WriteLine("Can not open connection ! " + ex);
            }

            return true;
        }
    }
}
