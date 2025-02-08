using AutoMapper;
using ClinicasCRM.Core.Dtos.Agendamento;

namespace ClinicasCRM.Api.Profiles.Agendamento;

public class AgendamentoProfile : Profile
{
    public AgendamentoProfile()
    {
        CreateMap<Core.Models.Agendamento.Agendamento, AgendamentoDto>().ReverseMap();
    }
}
