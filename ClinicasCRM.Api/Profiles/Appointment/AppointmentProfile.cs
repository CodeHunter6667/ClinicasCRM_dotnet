using AutoMapper;
using ClinicasCRM.Core.Dtos.Appointment;

namespace ClinicasCRM.Api.Profiles.Appointment;

public class AppointmentProfile : Profile
{
    public AppointmentProfile()
    {
        CreateMap<Core.Models.Appointment.Appointment, AppointmentDto>().ReverseMap();
    }
}
