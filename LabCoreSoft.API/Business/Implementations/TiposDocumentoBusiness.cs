using LabCoreSoft.API.Business.Interfaces;
using LabCoreSoft.API.DTOs;
using LabCoreSoft.API.Repositories.Interfaces;

namespace LabCoreSoft.API.Business.Implementations
{
    public class TiposDocumentoBusiness : ITiposDocumentoBusiness
    {
        private readonly ITiposDocumentoRepository tiposDocumentoRepository;

        public TiposDocumentoBusiness(ITiposDocumentoRepository tiposDocumentoRepository)
        {
            this.tiposDocumentoRepository = tiposDocumentoRepository;
        }

        public async Task<List<TipoDocumentoDto>> GetTiposDocumentoAllAsync() =>
            await tiposDocumentoRepository.GetTiposDocumentoAllAsync();

    }
}
