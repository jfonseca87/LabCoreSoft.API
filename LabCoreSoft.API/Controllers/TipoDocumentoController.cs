using LabCoreSoft.API.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LabCoreSoft.API.Controllers
{
    [ApiController]
    [Route("api/tipodocumento")]
    public class TipoDocumentoController : ControllerBase
    {
        private readonly ITiposDocumentoBusiness tiposDocumentoBusiness;
        private readonly ILogger<TipoDocumentoController> logger;

        public TipoDocumentoController(ITiposDocumentoBusiness tiposDocumentoBusiness, ILogger<TipoDocumentoController> logger)
        {
            this.tiposDocumentoBusiness = tiposDocumentoBusiness;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetTiposDocumentoAllAsync()
        {
            try
            {
                var tiposDocumento = await tiposDocumentoBusiness.GetTiposDocumentoAllAsync();
                return Ok(tiposDocumento);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error al obtener los tipos de documentos");
                throw;
            }
        }
    }
}
