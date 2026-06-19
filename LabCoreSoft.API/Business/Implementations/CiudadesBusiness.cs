using LabCoreSoft.API.Business.Interfaces;
using LabCoreSoft.API.DTOs;
using LabCoreSoft.API.Repositories.Interfaces;

namespace LabCoreSoft.API.Business.Implementations
{
    public class CiudadesBusiness : ICiudadesBusiness
    {
        private readonly ICiudadesRepository ciudadesRepository;

        public CiudadesBusiness(ICiudadesRepository ciudadesRepository)
        {
            this.ciudadesRepository = ciudadesRepository;
        }

        public async Task<List<CiudadDto>> GetCiudadesByDepartamentoAsync() =>
            await ciudadesRepository.GetCiudadesByDepartamentoAsync();
    }
}
