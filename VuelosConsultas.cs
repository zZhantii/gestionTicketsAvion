using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos
{
    internal class VuelosConsultas
    {
        private ConexionMySql conexionMySql;
        private List<Vuelo> mVuelos;
        public VuelosConsultas()
        {
            conexionMySql = new ConexionMySql();
            mVuelos = new List<Vuelo>();
       
        }
        //Mostrar datos
        //Devuele una lista de vuelos con el filtro establecido
        public List<Vuelo> getVuelos(string filtro)
        {
            
            string QUERY = "SELECT * FROM vuelos ";
            MySqlDataReader mReader = null;
            try
            {
                if (filtro != "")
                {
                    QUERY += " WHERE " +
                           "Vuelo_ID LIKE '%" + filtro + "%' OR " +
                           "Nombre LIKE '%" + filtro + "%' OR " +
                           "Apellido LIKE '%" + filtro + "%' OR " +
                           "Origen LIKE '%" + filtro + "%' OR " +
                           "Destino LIKE '%" + filtro + "%';";
                }   
                //Guarda la consulta
                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySql.getConexion();
                mReader = mComando.ExecuteReader();

                Vuelo mVuelo = null;
                while (mReader.Read())
                {
                    mVuelo = new Vuelo();
                    mVuelo.Vuelo_ID = mReader.GetInt16("Vuelo_ID");
                    mVuelo.Nombre = mReader.GetString("Nombre");
                    mVuelo.Apellido = mReader.GetString("Apellido");
                    mVuelo.Origen = mReader.GetString("Origen");
                    mVuelo.Destino = mReader.GetString("Destino");
                    mVuelo.Asiento = mReader.GetString("Asiento");
                    mVuelo.Fila = mReader.GetInt16("Fila");
                    mVuelo.Fecha_Vuelta = mReader.GetDateTime("Fecha_Vuelta");
                    mVuelo.Fecha_Ida = mReader.GetDateTime("Fecha_Ida");
                    mVuelos.Add(mVuelo);
                }
                mReader.Close();
            }
            catch (Exception)
            {

                throw;
            }

            return mVuelos;            
        }

        internal bool agregarVuelos(Vuelo mVuelo)
        {
            //Crear datos
            string INSERT = "INSERT INTO vuelos(Nombre, Apellido, Origen, Destino, Fecha_Ida, Fecha_Vuelta) " +
                    "values (@Nombre, @Apellido, @Destino, @Origen, @Fecha_Ida, @Fecha_Vuelta)";

            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMySql.getConexion());

            mCommand.Parameters.Add(new MySqlParameter("@Nombre", mVuelo.Nombre));
            mCommand.Parameters.Add(new MySqlParameter("@Apellido", mVuelo.Apellido));
            mCommand.Parameters.Add(new MySqlParameter("@Destino", mVuelo.Destino));
            mCommand.Parameters.Add(new MySqlParameter("@Origen", mVuelo.Origen));
            mCommand.Parameters.Add(new MySqlParameter("@Fecha_Ida", mVuelo.Fecha_Ida));
            mCommand.Parameters.Add(new MySqlParameter("@Fecha_Vuelta", mVuelo.Fecha_Vuelta));

            //Si la consulta es mayor a 0, se hizo correctamente
            return mCommand.ExecuteNonQuery() > 0;
        }

        internal bool modificarVuelos(Vuelo mVuelo)
        {
            string UPDATE = "UPDATE vuelos SET " +
                "Nombre = @Nombre, " +
                "Apellido = @Apellido, " +
                "Origen = @Origen, " +
                "Destino = @DestinO " +
                "WHERE Vuelo_ID = @Vuelo_ID;";

            MySqlCommand mCommand = new MySqlCommand(UPDATE, conexionMySql.getConexion());

            mCommand.Parameters.Add(new MySqlParameter("@Nombre", mVuelo.Nombre));
            mCommand.Parameters.Add(new MySqlParameter("@Apellido", mVuelo.Apellido));
            mCommand.Parameters.Add(new MySqlParameter("@Destino", mVuelo.Destino));
            mCommand.Parameters.Add(new MySqlParameter("@Origen", mVuelo.Origen));
            mCommand.Parameters.Add(new MySqlParameter("@Vuelo_ID", mVuelo.Vuelo_ID));

            //Si la consulta es mayor a 0, se hizo correctamente
            return mCommand.ExecuteNonQuery() > 0;
        }
        internal bool eliminarProducto(Vuelo mVuelo)
        {
            string DELETE = "DELETE FROM vuelos WHERE Vuelo_ID = @Vuelo_ID;";

            MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMySql.getConexion());

            //Si la consulta es mayor a 0, se hizo correctamente
            return mCommand.ExecuteNonQuery() > 0;
        }
    }  
}