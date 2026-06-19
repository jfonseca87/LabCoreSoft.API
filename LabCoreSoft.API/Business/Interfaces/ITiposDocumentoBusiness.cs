using LabCoreSoft.API.DTOs;

namespace LabCoreSoft.API.Business.Interfaces
{
    public interface ITiposDocumentoBusiness
    {
        Task<List<TipoDocumentoDto>> GetTiposDocumentoAllAsync();
    }
}