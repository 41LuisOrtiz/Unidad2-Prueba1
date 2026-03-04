using System.ComponentModel.DataAnnotations;
using Unidad2_Prueba1.Moldes;   
namespace Unidad2_Prueba1.Features.Pacientes
{
    public class PacientesDomainService
    {
        public PacientesDomainService() { }
        public bool guardarPaciente(Paciente paciente)
        {
            // nombre no puede estar vacio 
            if (string.IsNullOrEmpty(paciente.Nombre))
            {
                return false;
            }
            else if ((paciente.Identidad.Length) < 13 
                || string.IsNullOrEmpty(paciente.Identidad))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(paciente.NumeroTelefonico)
                ||paciente.NumeroTelefonico.Length<8) {
                return false;
            }
            // si la fecha de nacimiento es mayor a la fecha actual, no se puede guardar el paciente
            else if (DateTime.Parse(paciente.FechaNacimiento)> DateTime.Now)
            {
                return false;
            }
            return true;
        }

    }
}
