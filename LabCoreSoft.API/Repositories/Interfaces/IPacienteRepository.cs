using LabCoreSoft.API.DTOs;

namespace LabCoreSoft.API.Repositories.Interfaces
{
    public interface IPacienteRepository
    {
        Task<int> CrearPacienteAsync(CrearPacienteDto paciente);
        Task<List<ObtenerPacienteDto>> GetPacientesAsync();
    }
}