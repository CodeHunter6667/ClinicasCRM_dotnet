using AutoMapper;
using ClinicasCRM.Core.Dtos.Procedimento;

namespace ClinicasCRM.Api.Profiles.Procedimento;

public class ProcedimentoProfile : Profile
{
    public ProcedimentoProfile()
    {
        CreateMap<ClinicasCRM.Core.Models.Procedimento.Procedimento, ProcedimentoDto>().ReverseMap();
    }
}
