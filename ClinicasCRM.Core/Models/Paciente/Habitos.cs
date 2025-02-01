using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.Models.Base;
using ClinicasCRM.Core.Models.Pessoa;

namespace ClinicasCRM.Core.Models.Paciente;
public class Habitos : EntidadeBase
{
    public bool AlimentacaoBalanceada { get; set; }
    public bool IntestinoRegular { get; set; }
    public bool SonoRegular { get; set; }
    public bool PraticaAtividadesFisicas { get; set; }
    public int DiasAtividadeFisica { get; set; }
    public bool Fumante { get; set; }
    public bool ConsomeBebidaAlcoolica { get; set; }
    public bool UsoAcidosNaPele { get; set; }
    public EFrequenciaConsumoAlcool ConsumoAlcool { get; set; }
    public string AcidosUsados { get; set; } = string.Empty;
    public bool UsaProtetorSolarDiario { get; set; }
    public long ClienteId { get; set; }
    public PessoaFisica Cliente { get; set; } = new();
}
