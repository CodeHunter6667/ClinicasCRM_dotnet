using ClinicasCRM.Core.Models.Avaliacao;
using ClinicasCRM.Core.Models.Base;

namespace ClinicasCRM.Core.Models.Paciente;
public class Medidas : EntidadeBase
{
    public double Peso { get; set; }
    public double Altura { get; set; }
    public double Busto { get; set; }
    public double BracoEsquerdo { get; set; }
    public double BracoDireito { get; set; }
    public double AbdomenSuperior { get; set; }
    public double Quadril { get; set; }
    public double CoxaEsquerda { get; set; }
    public double CoxaDireita { get; set; }
    public double PanturrilhaEsquerda { get; set; }
    public double PanturrilhaDireita { get; set; }
    public DateTime DataMedicao { get; set; }
    public List<AvaliacaoCorporal> AvaliacoesCorporais { get; set; } = new List<AvaliacaoCorporal>();
}
