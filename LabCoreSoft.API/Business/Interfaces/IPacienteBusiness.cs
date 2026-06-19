using LabCoreSoft.API.DTOs;

namespace LabCoreSoft.API.Business.Interfaces
{
    public interface IPacienteBusiness
    {
        Task<int> CreatePacienteAsync(CrearPacienteDto paciente);
        Task<List<ObtenerPacienteDto>> GetPacientesAsync();
    }
}