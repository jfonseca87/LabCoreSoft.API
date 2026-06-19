using LabCoreSoft.API.Business.Interfaces;
using LabCoreSoft.API.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace LabCoreSoft.API.Controllers
{
    [ApiController]
    [Route("api/paciente")]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteBusiness pacienteBusiness;
        private readonly ILogger<PacienteController> logger;

        public PacienteController(IPacienteBusiness pacienteBusiness, ILogger<PacienteController> logger)
        {
            this.pacienteBusiness = pacienteBusiness;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetPacientesAsync()
        {
            try
            {
                var pacientes = await pacienteBusiness.GetPacientesAsync();
                return Ok(pacientes);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error al obtener pacientes");
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> CrearPacienteAsync(CrearPacienteDto paciente)
        {
            try
            {
                var nuevoPacienteId = await pacienteBusiness.CreatePacienteAsync(paciente);
                return Created(string.Empty, nuevoPacienteId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error al crear paciente");
                throw;
            }
        }
    }
}
