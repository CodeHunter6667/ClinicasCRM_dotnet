using AutoMapper;
using ClinicasCRM.Core.Dtos.Paciente;
using ClinicasCRM.Core.Models.Paciente;

namespace ClinicasCRM.Api.Profiles.Paciente;

public class HabitosFemininosProfile : Profile
{
    public HabitosFemininosProfile()
    {
        CreateMap<HabitosFemininos, HabitosFemininosDto>().ReverseMap();
    }
}
