using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuniVD_Geo.Clases
{
    public class clsMetodos
    {
        #region Metodo para cargar la consulta SQL en DataAdapter

        public static DataTable GetSql(string mySql, int cbo = 0)
        {
            
            //DataTable para retorno
            DataTable myDataTable = new DataTable();
            //Abro la conexión a la base de datos
            Clases.clsGlobales.Con.Open();
            //Declaro el comando y le pasos los parámetros            
            SqlCommand cmd = new SqlCommand(mySql, Clases.clsGlobales.Con);
            // Declaro el Adaptador y lo instancio
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //Paso los datos de la consulta al DataAdapter
            adapter.Fill(myDataTable);
            //Cierro la Conexión
            Clases.clsGlobales.Con.Close();
            //Retornar DataTable
            return myDataTable;
            
        }

        #endregion
    }
}
