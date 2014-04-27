using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Conexion
    {
        public static SqlConnection getConexion()
        {

            SqlConnection conn = new SqlConnection(@"Data Source= localhost\SQLSERVER2008; Initial Catalog = GD1C2014; User Id= sa; Password = gestiondedatos");
            conn.Open();
            return conn;


        }
    }
}