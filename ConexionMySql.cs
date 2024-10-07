using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos
{
    //Heredo las variables para hacer la conexion a la base de datos
    internal class ConexionMySql : Conexion
    {
        private MySqlConnection connection;
        private string cadenaConexion;
        //Constructor para la clase
        public ConexionMySql()
        {
            cadenaConexion = "Database= " + database + 
                "; DataSource=" + server + 
                "; User Id= " + user + 
                "; Password=" + password +
                "; convert zero datetime=True";

            connection = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection getConexion()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return connection;
        }
    }
}
