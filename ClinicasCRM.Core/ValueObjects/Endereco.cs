using ClinicasCRM.Core.Models.Base;
using ClinicasCRM.Core.Models.Pessoa;

namespace ClinicasCRM.Core.ValueObjects;
public class Endereco : EntidadeBase
{
    public string Logradouro { get; set; } = string.Empty;
    public string Numero { get; set; } = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public string Complemento { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string Uf { get; set; } = string.Empty;
    public string Cep { get; set; } = string.Empty;
    public List<PessoaFisica> PessoasFisicas { get; set; } = new List<PessoaFisica>();
    public List<PessoaJuridica> PessoaJuridicas { get; set; } = new List<PessoaJuridica>();
}
