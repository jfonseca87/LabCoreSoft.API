using AutoMapper;
using LabCoreSoft.API.DTOs;
using LabCoreSoft.API.Models;

namespace LabCoreSoft.API.Repositories.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Ciudad, CiudadDto>();
            CreateMap<Departamento, DepartamentoDto>();
            CreateMap<TipoDocumento, TipoDocumentoDto>();
            CreateMap<CrearPacienteDto, Paciente>();
            CreateMap<Paciente, ObtenerPacienteDto>()
                .ForMember(dest => dest.NombresCompletos, opt => opt.MapFrom(src => src.Nombres + " " + src.Apellidos))
                .ForMember(dest => dest.DocumentoNombre, opt => opt.MapFrom(src => src.IdTipoDocumentoNavigation.Tipo))
                .ForMember(dest => dest.CiudadNombre, opt => opt.MapFrom(src => src.IdCiudadNavigation.Nombre));

        }
    }
}
