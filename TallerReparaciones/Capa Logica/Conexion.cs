using System.Configuration;
using System.Data.SqlClient;

namespace TallerReparaciones.Capa_Logica
{
    public class Conexion
    {
        public static SqlConnection AbrirConexion()
        {
            string cadena = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }
}
