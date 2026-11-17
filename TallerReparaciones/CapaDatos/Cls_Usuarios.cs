namespace TallerReparaciones.CapaDatos
{
    public class Cls_Usuarios
    {
        private int usuarioID;
        private string nombre;
        private string correo;
        private string telefono;

        public int UsuarioID
        {
            get { return usuarioID; }
            set { usuarioID = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public Cls_Usuarios() { }

        public Cls_Usuarios(int usuarioID, string nombre, string correo, string telefono)
        {
            this.usuarioID = usuarioID;
            this.nombre = nombre;
            this.correo = correo;
            this.telefono = telefono;
        }
    }
}
