using AutoMapper;
using ClinicasCRM.Core.Dtos.Patient;
using ClinicasCRM.Core.Models.Patient;

namespace ClinicasCRM.Api.Profiles.Patient;

public class FemaleHabitsProfile : Profile
{
    public FemaleHabitsProfile()
    {
        CreateMap<FemaleHabits, FemaleHabitsDto>().ReverseMap();
    }
}
