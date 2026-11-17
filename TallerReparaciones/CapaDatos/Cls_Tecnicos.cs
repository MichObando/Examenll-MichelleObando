namespace TallerReparaciones.CapaDatos
{
    public class Cls_Tecnicos
    {
        private int tecnicoID;
        private string nombre;
        private string especialidad;

        public int TecnicoID
        {
            get { return tecnicoID; }
            set { tecnicoID = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        public Cls_Tecnicos() { }

        public Cls_Tecnicos(int tecnicoID, string nombre, string especialidad)
        {
            this.tecnicoID = tecnicoID;
            this.nombre = nombre;
            this.especialidad = especialidad;
        }
    }
}
