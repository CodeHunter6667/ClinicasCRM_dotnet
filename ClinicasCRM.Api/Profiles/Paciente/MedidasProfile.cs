using AutoMapper;
using ClinicasCRM.Core.Dtos.Paciente;
using ClinicasCRM.Core.Models.Paciente;

namespace ClinicasCRM.Api.Profiles.Paciente;

public class MedidasProfile : Profile
{
    public MedidasProfile()
    {
        CreateMap<Medidas, MedidasDto>().ReverseMap();
    }
}
