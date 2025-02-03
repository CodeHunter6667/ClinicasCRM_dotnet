using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Repositorios.Base;

namespace ClinicasCRM.Api.Repositorios.Agendamento;

public class AgendamentoRepositorio : RepositorioBase<ClinicasCRM.Core.Models.Agendamento.Agendamento>
{
    public AgendamentoRepositorio(AppDbContext context) : base(context)
    {
    }
}
