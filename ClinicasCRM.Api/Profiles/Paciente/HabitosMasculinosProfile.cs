using AutoMapper;
using ClinicasCRM.Core.Dtos.Paciente;
using ClinicasCRM.Core.Models.Paciente;

namespace ClinicasCRM.Api.Profiles.Paciente;

public class HabitosMasculinosProfile : Profile
{
    public HabitosMasculinosProfile()
    {
        CreateMap<HabitosMasculinos, HabitosMasculinosDto>().ReverseMap();
    }
}
