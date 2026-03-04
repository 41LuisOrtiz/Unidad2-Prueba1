using System;
using Unidad2_Prueba1.Moldes;
namespace Unidad2_Prueba1.Features.Pacientes
{
    public class PacientesService
    {
        private List<Paciente> pacientes = new List<Paciente>();
        private PacientesDomainService pacientesDomainService;

        public PacientesService()
        {
            Paciente paciente1 = new Paciente(1, "Juan Pablo Ortiz", "0801199012345", "01/01/1990", "12345678");
            Paciente paciente2 = new Paciente(2, "Maria Elena Lopez", "0801199212345", "01/01/1992", "87654321");
            Paciente paciente3 = new Paciente(3, "Carlos Alberto Castro", "0801199312345", "01/01/1993", "56781234");
            Paciente paciente4 = new Paciente(4, "Ana Sofia Castellanos", "0801199412345", "01/01/1994", "43218765");
            pacientes.Add(paciente1);
            pacientes.Add(paciente2);
            pacientes.Add(paciente3);
            pacientes.Add(paciente4);

            pacientesDomainService = new PacientesDomainService();
        }

        public List<Paciente> ObtenerPacientes()
        {
            return pacientes;
        }
        // Consultar por id 
        public Paciente GetPacientePorId(int id)
        {
            return pacientes.Where(p => p.Id == id).First();
        }
        // nuevo paciente
        public void AgregarNuevoPaciente(Paciente paciente)
        {
            if (!pacientesDomainService.guardarPaciente(paciente))
            {

                return;
            }
            pacientes.Add(paciente);
        }

        public void ActualizarLibro(Paciente pacienteActualizado)
        {
            Paciente? Existente = pacientes.Where(x => x.Id == pacienteActualizado.Id).FirstOrDefault();
            if (Existente == null)
            {
                return;
            }
            Existente.Nombre = pacienteActualizado.Nombre;
            Existente.FechaNacimiento = pacienteActualizado.FechaNacimiento;
            Existente.NumeroTelefonico = pacienteActualizado.NumeroTelefonico;
            Existente.Identidad = pacienteActualizado.Identidad;
            Existente.Activo = pacienteActualizado.Activo;


        }
        public void EliminarPaciente(int id)
        {
            Paciente? Existente = pacientes.Where(x => x.Id == id).FirstOrDefault();
            if (Existente == null)
            {
                return;
            }
            Existente.Activo = false;
        }
    }
}
