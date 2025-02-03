using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Repositorios.Base;
using ClinicasCRM.Core.Models.Avaliacao;

namespace ClinicasCRM.Api.Repositorios.Avaliacao;

public class AvaliacaoCorporalRepositorio : RepositorioBase<AvaliacaoCorporal>
{
    public AvaliacaoCorporalRepositorio(AppDbContext context) : base(context)
    {
    }
}
