using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuniVD_Geo.Clases
{
    public class clsGlobales
    {
        //Cadenas de Conexion dell Gabi
        public static string SqlCadConexion = "Data Source = PC17\\SQLEXPRESS;Initial Catalog=MuniVd_Geo; Integrated Security = True; Connection Timeout=45";

        // ------------------------------------------ //

        //Command        
        public static SqlCommand cmd = new SqlCommand();

        // Indicamos que conexión usaremos para Sql.
        public static SqlConnection Con = new SqlConnection(SqlCadConexion);
        public static SqlConnection ConB = null;
    }
}
