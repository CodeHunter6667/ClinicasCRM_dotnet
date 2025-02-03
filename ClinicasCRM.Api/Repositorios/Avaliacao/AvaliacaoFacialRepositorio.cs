using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Repositorios.Base;
using ClinicasCRM.Core.Models.Avaliacao;

namespace ClinicasCRM.Api.Repositorios.Avaliacao;

public class AvaliacaoFacialRepositorio : RepositorioBase<AvaliacaoFacial>
{
    public AvaliacaoFacialRepositorio(AppDbContext context) : base(context)
    {
    }
}
