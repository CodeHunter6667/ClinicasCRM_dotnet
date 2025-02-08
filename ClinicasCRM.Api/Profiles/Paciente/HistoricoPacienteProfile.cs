using AutoMapper;
using ClinicasCRM.Core.Dtos.Paciente;
using ClinicasCRM.Core.Models.Paciente;

namespace ClinicasCRM.Api.Profiles.Paciente;

public class HistoricoPacienteProfile : Profile
{
    public HistoricoPacienteProfile()
    {
        CreateMap<HistoricoPaciente, HistoricoPacienteDto>().ReverseMap();
    }
}
