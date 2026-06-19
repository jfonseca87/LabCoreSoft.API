using LabCoreSoft.API.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LabCoreSoft.API.Controllers
{
    [ApiController]
    [Route("api/departamento")]
    public class DepartamentoController : ControllerBase
    {
        private readonly IDepartamentosBusiness departamentosBusiness;
        private readonly ILogger<DepartamentoController> logger;

        public DepartamentoController(IDepartamentosBusiness departamentosBusiness, ILogger<DepartamentoController> logger)
        {
            this.departamentosBusiness = departamentosBusiness;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartamentosAsync()
        {
            try
            {
                var departamentos = await departamentosBusiness.GetAllDepartamentosAsync();
                return Ok(departamentos);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error al obtener departamentos");
                throw;
            }
        }
    }
}
