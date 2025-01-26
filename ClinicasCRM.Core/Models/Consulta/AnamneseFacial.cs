using ClinicasCRM.Core.Models.Avaliacao;

namespace ClinicasCRM.Core.Models.Consulta;
public class AnamneseFacial : Anamnese
{
    public AvaliacaoFacial AvaliacaoFacial { get; set; } = new();
}
