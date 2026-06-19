using AutoMapper;
using LabCoreSoft.API.DTOs;
using LabCoreSoft.API.Models;
using LabCoreSoft.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LabCoreSoft.API.Repositories.EF_Implementations
{
    public class CiudadesRepository : ICiudadesRepository
    {
        private readonly LabCoreSoftMedicoContext db;
        private readonly IMapper mapper;

        public CiudadesRepository(LabCoreSoftMedicoContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public async Task<List<CiudadDto>> GetCiudadesByDepartamentoAsync()
        {
            var ciudades = await db.Ciudades.AsNoTracking().ToListAsync();
            return mapper.Map<List<CiudadDto>>(ciudades);
        }
    }
}
