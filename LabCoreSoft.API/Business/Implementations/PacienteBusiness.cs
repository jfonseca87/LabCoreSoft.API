using LabCoreSoft.API.Business.Interfaces;
using LabCoreSoft.API.DTOs;
using LabCoreSoft.API.Repositories.Interfaces;

namespace LabCoreSoft.API.Business.Implementations
{
    public class PacienteBusiness : IPacienteBusiness
    {
        private readonly IPacienteRepository pacienteRepository;

        public PacienteBusiness(IPacienteRepository pacienteRepository)
        {
            this.pacienteRepository = pacienteRepository;
        }

        public async Task<List<ObtenerPacienteDto>> GetPacientesAsync() =>
            await pacienteRepository.GetPacientesAsync();

        public async Task<int> CreatePacienteAsync(CrearPacienteDto paciente)
        {
            return await pacienteRepository.CrearPacienteAsync(paciente);
        }
    }
}
