using System;
using System.Data.SqlClient;
using TallerReparaciones.Capa_Logica;

namespace TallerReparaciones.Presentacion
{
    public partial class CatalogoTecnicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarTecnicos();
        }

        private void MostrarTecnicos()
        {
            SqlConnection conexion = Conexion.AbrirConexion();
            SqlCommand comando = new SqlCommand("select TecnicoID as ID, Nombre, Especialidad from Tecnicos", conexion);
            gvTecnicos.DataSource = comando.ExecuteReader();
            gvTecnicos.DataBind();
            conexion.Close();
        }

        private void LimpiarCampos()
        {
            txtTecnicoID.Text = "";
            txtNombre.Text = "";
            txtEspecialidad.Text = "";
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                int resultado = Tecnicos_CL.AgregarTecnico(txtNombre.Text, txtEspecialidad.Text);
                if (resultado > 0)
                {
                    lblMensaje.Text = "El técnico se agregó correctamente";
                    MostrarTecnicos();
                    LimpiarCampos();
                }
                else
                {
                    lblMensaje.Text = "No se pudo agregar el técnico";
                }
            }
            else
            {
                lblMensaje.Text = "Debe escribir el nombre del técnico";
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtTecnicoID.Text != "")
            {
                int tecnicoID = int.Parse(txtTecnicoID.Text);
                int resultado = Tecnicos_CL.ModificarTecnico(tecnicoID, txtNombre.Text, txtEspecialidad.Text);
                if (resultado > 0)
                {
                    lblMensaje.Text = "El técnico se modificó correctamente";
                    MostrarTecnicos();
                    LimpiarCampos();
                }
                else
                {
                    lblMensaje.Text = "No se encontró el técnico con ese ID";
                }
            }
            else
            {
                lblMensaje.Text = "Debe escribir el ID del técnico";
            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtTecnicoID.Text != "")
            {
                int tecnicoID = int.Parse(txtTecnicoID.Text);
                int resultado = Tecnicos_CL.BorrarTecnico(tecnicoID);
                if (resultado > 0)
                {
                    lblMensaje.Text = "El técnico se borró correctamente";
                    MostrarTecnicos();
                    LimpiarCampos();
                }
                else
                {
                    lblMensaje.Text = "No se pudo borrar el técnico (puede que tenga asignaciones)";
                }
            }
            else
            {
                lblMensaje.Text = "Debe escribir el ID del técnico";
            }
        }
    }
}
