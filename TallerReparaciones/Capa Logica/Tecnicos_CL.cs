using System.Data.SqlClient;

namespace TallerReparaciones.Capa_Logica
{
    public class Tecnicos_CL
    {
        public static int AgregarTecnico(string nombre, string especialidad)
        {
            int resultado = 0;
            try
            {
                SqlConnection conexion = Conexion.AbrirConexion();
                SqlCommand comando = new SqlCommand("insert into Tecnicos (Nombre, Especialidad) values (@nombre, @especialidad)", conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@especialidad", especialidad);
                resultado = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (SqlException)
            {
                resultado = 0;
            }
            return resultado;
        }

        public static int ModificarTecnico(int tecnicoID, string nombre, string especialidad)
        {
            int resultado = 0;
            try
            {
                SqlConnection conexion = Conexion.AbrirConexion();
                SqlCommand comando = new SqlCommand("update Tecnicos set Nombre = @nombre, Especialidad = @especialidad where TecnicoID = @id", conexion);
                comando.Parameters.AddWithValue("@id", tecnicoID);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@especialidad", especialidad);
                resultado = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (SqlException)
            {
                resultado = 0;
            }
            return resultado;
        }

        public static int BorrarTecnico(int tecnicoID)
        {
            int resultado = 0;
            try
            {
                SqlConnection conexion = Conexion.AbrirConexion();
                SqlCommand comando = new SqlCommand("delete from Tecnicos where TecnicoID = @id", conexion);
                comando.Parameters.AddWithValue("@id", tecnicoID);
                resultado = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (SqlException)
            {
                resultado = 0;
            }
            return resultado;
        }
    }
}
