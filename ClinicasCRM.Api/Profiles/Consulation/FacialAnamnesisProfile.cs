using AutoMapper;
using ClinicasCRM.Core.Dtos.Consulation;
using ClinicasCRM.Core.Models.Consulation;

namespace ClinicasCRM.Api.Profiles.Consulation;

public class FacialAnamnesisProfile : Profile
{
    public FacialAnamnesisProfile()
    {
        CreateMap<FacialAnamnesis, FacialAnamnesisDto>().ReverseMap();
    }
}
