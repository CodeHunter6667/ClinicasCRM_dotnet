using AutoMapper;
using ClinicasCRM.Core.Dtos.Pessoa;
using ClinicasCRM.Core.Models.Person;

namespace ClinicasCRM.Api.Profiles.Person
{
    public class ProfessionalProfile : Profile
    {
        public ProfessionalProfile()
        {
            CreateMap<Professional, ProfessionalDto>().ReverseMap();
        }
    }
}
