using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Servicos.Base;
using ClinicasCRM.Api.Servicos.Pessoa.Interfaces;
using ClinicasCRM.Core.Models.Pessoa;

namespace ClinicasCRM.Api.Servicos.Pessoa;

public class PessoaFisicaService : ServicoBase<PessoaFisica>, IPessoaFisicaService
{
    public PessoaFisicaService(AppDbContext context) : base(context)
    {
        
    }
}
