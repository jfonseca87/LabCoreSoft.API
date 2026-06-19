using LabCoreSoft.API.DTOs;

namespace LabCoreSoft.API.Business.Interfaces
{
    public interface IDepartamentosBusiness
    {
        Task<List<DepartamentoDto>> GetAllDepartamentosAsync();
    }
}