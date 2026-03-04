using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Unidad2_Prueba1.Features.Pacientes;
using Unidad2_Prueba1.Moldes;
namespace Unidad2_Prueba1.Controllers
{
    [Route("api/Controler")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
        private readonly PacientesService AppService;
        public PacientesController(PacientesService pacienteAppService)
        {
            this.AppService = pacienteAppService;
        }
        // Listar todos los pacientes.
        [HttpGet]
        [Route("ObtenerPacientes")]
        public IActionResult ObtenerPacientes()
        {
            return Ok(AppService.ObtenerPacientes());
        }


        // Consultar la información de un paciente por su Id.
        [HttpGet]
        [Route("ObtenerPacientePorId/{id}")]
        public IActionResult ObtenerPacientePorId(int id)
        {
            return Ok(AppService.GetPacientePorId(id));
        }
        // Agregar nuevos pacientes.
        [HttpGet]
        [Route("AgregarNuevoPaciente")]
        public IActionResult AgregarNuevoPaciente(Paciente paciente)
        {
            AppService.AgregarNuevoPaciente(paciente);
            return Ok();
        }
        // Modificar información de pacientes.
        [HttpGet] 
        [Route("ActualizarPaciente")]
        public IActionResult ActualizarPaciente(Paciente paciente)
        {
            AppService.ActualizarLibro(paciente);
            return Ok("Modificado");
        }
        // Eliminar pacientes.
        [HttpGet]
        [Route("EliminarPaciente/{id}")]
        public IActionResult EliminarPaciente(int id)
        {
            AppService.EliminarPaciente(id);
            return Ok("Eliminado");
        }
    }
}
