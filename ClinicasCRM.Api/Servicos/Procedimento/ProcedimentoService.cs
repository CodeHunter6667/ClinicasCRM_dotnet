using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Servicos.Base;
using ClinicasCRM.Api.Servicos.Base.Interfaces;

namespace ClinicasCRM.Api.Servicos.Procedimento;

public class ProcedimentoService : ServicoBase<ClinicasCRM.Core.Models.Procedimento.Procedimento>, IServicoBase
{
    public ProcedimentoService(AppDbContext context) : base(context)
    {
        
    }
}
