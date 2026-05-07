using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paqueteria.Data
{
    public class Conexion
    {
        private static string connectionString = "Server=127.0.0.1;Port=3306;Database=paqueteria_db;Uid=root;Pwd=mysql123;";
        public static MySqlConnection ObtenerConexion()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la BD: " + ex.Message);
            }
        }
    }
}

