using ClinicasCRM.Core.Models.Paciente;

namespace ClinicasCRM.Core.Models.Consulta;
public class AnamneseCorporal : Anamnese
{
    public string PrincipaisQueixas { get; set; } = string.Empty;
    public Medidas Medidas { get; set; } = new();
    public long MedidasId { get; set; }
    public string AnotacoesTratamentoEscolhido { get; set; } = string.Empty;
    public DateTime DataAvaliacao { get; set; } = DateTime.Now;
    public string Observacoes { get; set; } = string.Empty;
}
