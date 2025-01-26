using ClinicasCRM.Core.Models.Base;
using ClinicasCRM.Core.Models.Consulta;
using ClinicasCRM.Core.Models.Paciente;
using ClinicasCRM.Core.Models.Pessoa;

namespace ClinicasCRM.Core.Models.Avaliacao;
public class AvaliacaoCorporal : EntidadeBase
{
    public string PrincipaisQueixas { get; set; } = string.Empty;
    public Medidas Medidas { get; set; } = new();
    public PessoaFisica Cliente { get; set; } = new();
    public string AnotacoesTratamentoEscolhido { get; set; } = string.Empty;
    public DateTime DataAvaliacao { get; set; } = DateTime.Now;
    public string Observacoes { get; set; } = string.Empty;
    public List<AnamneseCorporal> AnamnesesCorporal { get; set; } = new List<AnamneseCorporal>();
}
