using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Repositorios.Base;
using ClinicasCRM.Core.Models.Pessoa;

namespace ClinicasCRM.Api.Repositorios.Pessoa;

public class PessoaJuridicaRepositorio : RepositorioBase<PessoaJuridica>
{
    public PessoaJuridicaRepositorio(AppDbContext context) : base(context)
    {
    }
}
