using LabCoreSoft.API.Business.Interfaces;
using LabCoreSoft.API.DTOs;
using LabCoreSoft.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LabCoreSoft.API.Business.Implementations
{
    public class DepartamentosBusiness : IDepartamentosBusiness
    {
        private readonly IDepartametosRepository departametosRepository;

        public DepartamentosBusiness(IDepartametosRepository departametosRepository)
        {
            this.departametosRepository = departametosRepository;
        }

        public async Task<List<DepartamentoDto>> GetAllDepartamentosAsync() =>
            await departametosRepository.GetAllDepartamentosAsync();
    }
}
