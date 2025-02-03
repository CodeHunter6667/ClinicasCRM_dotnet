using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Repositorios.Base;

namespace ClinicasCRM.Api.Repositorios.Procedimento;

public class ProcedimentoRepositorio : RepositorioBase<ClinicasCRM.Core.Models.Procedimento.Procedimento>
{
    public ProcedimentoRepositorio(AppDbContext context) : base(context)
    {
    }
}
