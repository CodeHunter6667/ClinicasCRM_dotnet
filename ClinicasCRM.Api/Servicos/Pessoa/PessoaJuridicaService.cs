using ClinicasCRM.Api.Repositorios.Pessoa;
using ClinicasCRM.Api.Servicos.Base;
using ClinicasCRM.Api.Servicos.Pessoa.Interfaces;
using ClinicasCRM.Core.Models.Pessoa;

namespace ClinicasCRM.Api.Servicos.Pessoa;

public class PessoaJuridicaService : ServicoBase<PessoaJuridica, PessoaJuridicaRepositorio>, IPessoaJuridicaService
{
}
