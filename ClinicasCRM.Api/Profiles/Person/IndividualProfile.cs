using AutoMapper;
using ClinicasCRM.Core.Dtos.Person;
using ClinicasCRM.Core.Models.Person;

namespace ClinicasCRM.Api.Profiles.Person;

public class IndividualProfile : Profile
{
    public IndividualProfile()
    {
        CreateMap<Individual, IndividualDto>().ReverseMap();
    }
}
