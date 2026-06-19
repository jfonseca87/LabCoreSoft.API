using LabCoreSoft.API.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LabCoreSoft.API.Controllers
{
    [ApiController]
    [Route("api/ciudades")]
    public class CiudadesController : ControllerBase
    {
        private readonly ICiudadesBusiness ciudadesBusiness;
        private readonly ILogger<CiudadesController> logger;

        public CiudadesController(ICiudadesBusiness ciudadesBusiness, ILogger<CiudadesController> logger)
        {
            this.ciudadesBusiness = ciudadesBusiness;
            this.logger = logger;
        }

        [HttpGet()]
        public async Task<IActionResult> GetCiudadesByDepartamentoAsync()
        {
            try
            {
                var ciudades = await ciudadesBusiness.GetCiudadesByDepartamentoAsync();
                return Ok(ciudades);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error al obtener las ciudades por departamento");
                throw;
            }
        }
    }
}
