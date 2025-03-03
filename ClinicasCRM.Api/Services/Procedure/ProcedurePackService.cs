using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Services.Base;
using ClinicasCRM.Api.Services.Procedure.Interfaces;
using ClinicasCRM.Core.Models.Procedure;

namespace ClinicasCRM.Api.Services.Procedure
{
    public class ProcedurePackService : BaseService<ProcedurePack>, IProcedurePackService
    {
        public ProcedurePackService(AppDbContext context) : base(context)
        {
        }
    }
}
