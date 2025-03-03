using AutoMapper;
using ClinicasCRM.Core.Dtos.Patient;
using ClinicasCRM.Core.Models.Patient;

namespace ClinicasCRM.Api.Profiles.Patient;

public class MaleHabitsProfile : Profile
{
    public MaleHabitsProfile()
    {
        CreateMap<MaleHabits, MaleHabitsDto>().ReverseMap();
    }
}
