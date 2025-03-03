using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Services.Base;
using ClinicasCRM.Api.Services.Procedure.Interfaces;

namespace ClinicasCRM.Api.Services.Procedimento;

public class ProcedureService : BaseService<ClinicasCRM.Core.Models.Procedure.Procedure>, IProcedureService
{
    public ProcedureService(AppDbContext context) : base(context)
    {
        
    }
}
