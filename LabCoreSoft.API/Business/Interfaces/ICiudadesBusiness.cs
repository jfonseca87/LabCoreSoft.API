using LabCoreSoft.API.DTOs;

namespace LabCoreSoft.API.Business.Interfaces
{
    public interface ICiudadesBusiness
    {
        Task<List<CiudadDto>> GetCiudadesByDepartamentoAsync();
    }
}