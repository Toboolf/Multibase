using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Multibase
{
    class HotelConnection
    {
        private MySqlConnection con;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public HotelConnection()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "hotel";
            uid = "multibase";
            password = "multibase";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            con = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {

            try
            {
                con.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("No se pudo conectar con el servidor.");
                        break;

                    case 1045:
                        Console.WriteLine("Usuario y/o contraseña inválidos.");
                        break;
                }
                return false;
            }

        }

        private bool CloseConnection()
        {

            try
            {
                con.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
    }
}
