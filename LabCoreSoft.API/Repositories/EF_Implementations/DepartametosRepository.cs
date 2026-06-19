using AutoMapper;
using LabCoreSoft.API.DTOs;
using LabCoreSoft.API.Models;
using LabCoreSoft.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LabCoreSoft.API.Repositories.EF_Implementations
{
    public class DepartametosRepository : IDepartametosRepository
    {
        private readonly LabCoreSoftMedicoContext db;
        private readonly IMapper mapper;

        public DepartametosRepository(LabCoreSoftMedicoContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public async Task<List<DepartamentoDto>> GetAllDepartamentosAsync()
        {
            var departamentos = await db.Departamentos.AsNoTracking().ToListAsync();
            return mapper.Map<List<DepartamentoDto>>(departamentos);
        }
    }
}
