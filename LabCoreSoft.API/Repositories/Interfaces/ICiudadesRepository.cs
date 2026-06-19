using LabCoreSoft.API.DTOs;

namespace LabCoreSoft.API.Repositories.Interfaces
{
    public interface ICiudadesRepository
    {
        Task<List<CiudadDto>> GetCiudadesByDepartamentoAsync();
    }
}