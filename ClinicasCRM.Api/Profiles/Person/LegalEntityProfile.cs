using AutoMapper;
using ClinicasCRM.Core.Dtos.Person;
using ClinicasCRM.Core.Models.Person;

namespace ClinicasCRM.Api.Profiles.Person;

public class LegalEntityProfile : Profile
{
    public LegalEntityProfile()
    {
        CreateMap<LegalEntity, LegalEntityDto>().ReverseMap();
    }
}
