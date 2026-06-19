using AutoMapper;
using LabCoreSoft.API.DTOs;
using LabCoreSoft.API.Models;
using LabCoreSoft.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LabCoreSoft.API.Repositories.EF_Implementations
{
    public class TiposDocumentoRepository : ITiposDocumentoRepository
    {
        private readonly LabCoreSoftMedicoContext db;
        private readonly IMapper mapper;

        public TiposDocumentoRepository(LabCoreSoftMedicoContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public async Task<List<TipoDocumentoDto>> GetTiposDocumentoAllAsync()
        {
            var tipos = await db.TiposDocumento.AsNoTracking().ToListAsync();
            return mapper.Map<List<TipoDocumentoDto>>(tipos);
        }
    }
}
