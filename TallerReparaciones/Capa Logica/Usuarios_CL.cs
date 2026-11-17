using System.Data.SqlClient;

namespace TallerReparaciones.Capa_Logica
{
    public class Usuarios_CL
    {
        public static int AgregarUsuario(string nombre, string correo, string telefono)
        {
            int resultado = 0;
            try
            {
                SqlConnection conexion = Conexion.AbrirConexion();
                SqlCommand comando = new SqlCommand("insert into Usuarios (Nombre, CorreoElectronico, Telefono) values (@nombre, @correo, @telefono)", conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@telefono", telefono);
                resultado = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (SqlException)
            {
                resultado = 0;
            }
            return resultado;
        }

        public static int ModificarUsuario(int usuarioID, string nombre, string correo, string telefono)
        {
            int resultado = 0;
            try
            {
                SqlConnection conexion = Conexion.AbrirConexion();
                SqlCommand comando = new SqlCommand("update Usuarios set Nombre = @nombre, CorreoElectronico = @correo, Telefono = @telefono where UsuarioID = @id", conexion);
                comando.Parameters.AddWithValue("@id", usuarioID);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@telefono", telefono);
                resultado = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (SqlException)
            {
                resultado = 0;
            }
            return resultado;
        }

        public static int BorrarUsuario(int usuarioID)
        {
            int resultado = 0;
            try
            {
                SqlConnection conexion = Conexion.AbrirConexion();
                SqlCommand comando = new SqlCommand("delete from Usuarios where UsuarioID = @id", conexion);
                comando.Parameters.AddWithValue("@id", usuarioID);
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
