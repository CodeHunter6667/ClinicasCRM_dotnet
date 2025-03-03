using AutoMapper;
using ClinicasCRM.Core.Dtos.Consulation;
using ClinicasCRM.Core.Models.Consulation;

namespace ClinicasCRM.Api.Profiles.Consulation;

public class BodyAnamnesisProfile : Profile
{
    public BodyAnamnesisProfile()
    {
        CreateMap<BodyAnamnesis, BodyAnamnesisDto>().ReverseMap();
    }
}
