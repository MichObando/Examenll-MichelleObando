using System;
using System.Data.SqlClient;
using TallerReparaciones.Capa_Logica;

namespace TallerReparaciones.Presentacion
{
    public partial class CatalogoUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void MostrarUsuarios()
        {
            SqlConnection conexion = Conexion.AbrirConexion();
            SqlCommand comando = new SqlCommand("select UsuarioID as ID, Nombre, CorreoElectronico as Correo, Telefono as Teléfono from Usuarios", conexion);
            gvUsuarios.DataSource = comando.ExecuteReader();
            gvUsuarios.DataBind();
            conexion.Close();
        }

        private void LimpiarCampos()
        {
            txtUsuarioID.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                int resultado = Usuarios_CL.AgregarUsuario(txtNombre.Text, txtCorreo.Text, txtTelefono.Text);
                if (resultado > 0)
                {
                    lblMensaje.Text = "El usuario se agregó correctamente";
                    MostrarUsuarios();
                    LimpiarCampos();
                }
                else
                {
                    lblMensaje.Text = "No se pudo agregar el usuario";
                }
            }
            else
            {
                lblMensaje.Text = "Debe escribir el nombre del usuario";
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtUsuarioID.Text != "")
            {
                int usuarioID = int.Parse(txtUsuarioID.Text);
                int resultado = Usuarios_CL.ModificarUsuario(usuarioID, txtNombre.Text, txtCorreo.Text, txtTelefono.Text);
                if (resultado > 0)
                {
                    lblMensaje.Text = "El usuario se modificó correctamente";
                    MostrarUsuarios();
                    LimpiarCampos();
                }
                else
                {
                    lblMensaje.Text = "No se encontró el usuario con ese ID";
                }
            }
            else
            {
                lblMensaje.Text = "Debe escribir el ID del usuario";
            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtUsuarioID.Text != "")
            {
                int usuarioID = int.Parse(txtUsuarioID.Text);
                int resultado = Usuarios_CL.BorrarUsuario(usuarioID);
                if (resultado > 0)
                {
                    lblMensaje.Text = "El usuario se borró correctamente";
                    MostrarUsuarios();
                    LimpiarCampos();
                }
                else
                {
                    lblMensaje.Text = "No se pudo borrar el usuario (puede que tenga equipos registrados)";
                }
            }
            else
            {
                lblMensaje.Text = "Debe escribir el ID del usuario";
            }
        }
    }
}
