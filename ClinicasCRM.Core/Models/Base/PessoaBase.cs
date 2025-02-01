using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.ValueObjects;

namespace ClinicasCRM.Core.Models.Base;
public class PessoaBase : EntidadeBase
{
    public string Telefone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public long EnderecoId { get; set; }
    public Endereco Endereco { get; set; } = new();
    public ETipoCadastro TipoCadastro { get; set; }
}
