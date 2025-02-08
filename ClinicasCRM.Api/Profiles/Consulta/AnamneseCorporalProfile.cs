using AutoMapper;
using ClinicasCRM.Core.Dtos.Consulta;
using ClinicasCRM.Core.Models.Consulta;

namespace ClinicasCRM.Api.Profiles.Consulta;

public class AnamneseCorporalProfile : Profile
{
    public AnamneseCorporalProfile()
    {
        CreateMap<AnamneseCorporal, AnamneseCorporalDto>().ReverseMap();
    }
}
