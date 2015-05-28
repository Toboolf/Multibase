using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;

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

        public void AgregaCliente(ClienteHotel cliente)
        {
            string query = "INSERT INTO cliente (Nombre, Ap_pat, Ap_mat) VALUES('"+ cliente.nombre +"', '"+ cliente.apPat  +"', '"+ cliente.apMat  +"')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, con);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public List<HabitacionHotel> HabitacionesDisponibles() 
        {
            List<HabitacionHotel> disponibles = new List<HabitacionHotel>();

            string query = "select h.No_habitacion, x.nombre " +
                            "from habitacion h, tipo_habitacion x "+
                            "where h.tipo_habitacion_idtipo_habitacion = x.idtipo_habitacion " + 
                            "and h.estado = 0 "+
                            "order by h.No_habitacion";


            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, con);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    HabitacionHotel aux = new HabitacionHotel();
                    aux.numero = Convert.ToInt32(dataReader["No_habitacion"] + "");
                    aux.tipo = dataReader["nombre"] + "";
                    disponibles.Add(aux);
                    Console.WriteLine(aux.numero + aux.tipo);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return disponibles;
            }
            else
            {
                return disponibles;
            }
        }

        public ObservableCollection<ClienteHotel> Clientes() 
        {
            ObservableCollection<ClienteHotel> clientes = new ObservableCollection<ClienteHotel>();

            string query = "select * " +
                           "from cliente " +
                           "order by Ap_pat";


            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                
                while (dataReader.Read())
                {
                    ClienteHotel aux = new ClienteHotel();
                    aux.nombre = dataReader["nombre"] + "";
                    aux.apPat = dataReader["Ap_pat"] + "";
                    aux.apMat = dataReader["Ap_mat"] + "";
                    clientes.Add(aux);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return clientes;
            }
            else
            {
                return clientes;
            }

        }

        public List<Reservacion> MostrarReservacionesCliente()
        {
            List<Reservacion> reservaciones = new List<Reservacion>();

                return reservaciones;
        }

    }
}
