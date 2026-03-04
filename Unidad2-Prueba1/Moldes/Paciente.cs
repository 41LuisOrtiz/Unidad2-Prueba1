namespace Unidad2_Prueba1.Moldes
{
    public class Paciente
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }
        public string Identidad { get; set; }
        public string FechaNacimiento { get; set; } // "dd/mm/aaaa"
        public string NumeroTelefonico { get; set; }
        public Boolean Activo { get; set; }= true;

        public Paciente(int id, string nombre, string identidad, string fecha, string numero)
        {
            Id = id;
            Nombre = nombre;
            Identidad = identidad;
            FechaNacimiento = fecha;
            NumeroTelefonico = numero;
            Activo = true;
        }
    }
}
