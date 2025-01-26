using ClinicasCRM.Core.Models.Base;

namespace ClinicasCRM.Core.Models.Pessoa;
public class PessoaJuridica : PessoaBase
{
    public string RazaoSocial { get; set; } = string.Empty;
    public string NomeFantasia { get; set; } = string.Empty;
    public string Cnpj { get; set; } = string.Empty;
    public string InscricaoEstadual { get; set; } = string.Empty;
    public string InscricaoMunicipal { get; set; } = string.Empty;
}
