using ClinicasCRM.Api.Repositorios.ValueObjects;
using ClinicasCRM.Api.Servicos.Base;
using ClinicasCRM.Api.Servicos.ValueObjects.Interfaces;
using ClinicasCRM.Core.ValueObjects;

namespace ClinicasCRM.Api.Servicos.ValueObjects;

public class EnderecoService : ServicoBase<Endereco, EnderecoRepositorio>, IEnderecoService
{
}
