using AutoMapper;
using ClinicasCRM.Core.Dtos.Consulta;
using ClinicasCRM.Core.Models.Consulta;

namespace ClinicasCRM.Api.Profiles.Consulta;

public class AnamneseFacialProfile : Profile
{
    public AnamneseFacialProfile()
    {
        CreateMap<AnamneseFacial, AnamneseFacialDto>().ReverseMap();
    }
}
