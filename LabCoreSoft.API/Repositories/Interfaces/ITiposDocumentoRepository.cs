using LabCoreSoft.API.DTOs;

namespace LabCoreSoft.API.Repositories.Interfaces
{
    public interface ITiposDocumentoRepository
    {
        Task<List<TipoDocumentoDto>> GetTiposDocumentoAllAsync();
    }
}