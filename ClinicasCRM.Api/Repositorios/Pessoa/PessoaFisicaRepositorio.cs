using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Repositorios.Base;
using ClinicasCRM.Core.Models.Pessoa;

namespace ClinicasCRM.Api.Repositorios.Pessoa;

public class PessoaFisicaRepositorio : RepositorioBase<PessoaFisica>
{
    public PessoaFisicaRepositorio(AppDbContext context) : base(context)
    {
    }
}
