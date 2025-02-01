using ClinicasCRM.Core.Models.Avaliacao;

namespace ClinicasCRM.Core.Models.Consulta;
public class AnamneseCorporal : Anamnese
{
    public AvaliacaoCorporal AvaliacaoCorporal { get; set; } = new();
    public long AvaliacaoCorporalId { get; set; }
}
