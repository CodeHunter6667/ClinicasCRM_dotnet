using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Servicos.Base;
using ClinicasCRM.Api.Servicos.Pessoa.Interfaces;
using ClinicasCRM.Core.Models.Pessoa;

namespace ClinicasCRM.Api.Servicos.Pessoa;

public class PessoaJuridicaService : ServicoBase<PessoaJuridica>, IPessoaJuridicaService
{
    public PessoaJuridicaService(AppDbContext context) : base(context)
    {
        
    }
}
