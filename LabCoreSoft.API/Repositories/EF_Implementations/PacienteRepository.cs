using AutoMapper;
using LabCoreSoft.API.DTOs;
using LabCoreSoft.API.Models;
using LabCoreSoft.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LabCoreSoft.API.Repositories.EF_Implementations
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly LabCoreSoftMedicoContext db;
        private readonly IMapper mapper;

        public PacienteRepository(LabCoreSoftMedicoContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public async Task<List<ObtenerPacienteDto>> GetPacientesAsync()
        {
            var pacientes = await db.Pacientes.AsNoTracking()
                .Include(x => x.IdTipoDocumentoNavigation)
                .Include(x => x.IdCiudadNavigation)
                .ToListAsync();
            return mapper.Map<List<ObtenerPacienteDto>>(pacientes);
        }

        public async Task<int> CrearPacienteAsync(CrearPacienteDto paciente)
        {
            var pacienteNuevo = mapper.Map<Paciente>(paciente);
            db.Pacientes.Add(pacienteNuevo);
            await db.SaveChangesAsync();

            return pacienteNuevo.Id;
        }
    }
}
