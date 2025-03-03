using AutoMapper;
using ClinicasCRM.Core.Dtos.Patient;
using ClinicasCRM.Core.Models.Patient;

namespace ClinicasCRM.Api.Profiles.Patient;

public class MeasurementsProfile : Profile
{
    public MeasurementsProfile()
    {
        CreateMap<Measurements, MeasurementsDto>().ReverseMap();
    }
}
