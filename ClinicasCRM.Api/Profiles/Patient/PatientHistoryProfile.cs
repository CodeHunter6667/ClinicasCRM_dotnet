using AutoMapper;
using ClinicasCRM.Core.Dtos.Patient;
using ClinicasCRM.Core.Models.Patient;

namespace ClinicasCRM.Api.Profiles.Patient;

public class PatientHistoryProfile : Profile
{
    public PatientHistoryProfile()
    {
        CreateMap<PatientHistory, PatientHistoryDto>().ReverseMap();
    }
}
