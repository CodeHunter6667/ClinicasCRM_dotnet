using AutoMapper;
using ClinicasCRM.Core.Dtos.Procedure;

namespace ClinicasCRM.Api.Profiles.Procedure;

public class ProcedureProfile : Profile
{
    public ProcedureProfile()
    {
        CreateMap<ClinicasCRM.Core.Models.Procedure.Procedure, ProcedureDto>().ReverseMap();
    }
}
