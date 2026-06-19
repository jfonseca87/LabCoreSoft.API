using LabCoreSoft.API.DTOs;

namespace LabCoreSoft.API.Repositories.Interfaces
{
    public interface IDepartametosRepository
    {
        Task<List<DepartamentoDto>> GetAllDepartamentosAsync();
    }
}