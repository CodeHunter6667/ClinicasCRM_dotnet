using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.Models.Base;
using ClinicasCRM.Core.Models.Pessoa;

namespace ClinicasCRM.Core.Models.Agendamento;
public class Agendamento : EntidadeBase
{
    public PessoaFisica Cliente { get; set; } = new();
    public long ClienteId { get; set; }
    public string SalaAtendimento { get; set; } = string.Empty;
    public Procedimento.Procedimento Procedimento{ get; set; } = new();
    public long ProcedimentoId { get; set; }
    public TimeSpan HoraAtendimento { get; set; }
    public DateTime DataAtendimento { get; set; }
    public string Profissional { get; set; } = string.Empty;
    public EStatusAtendimento StatusAtendimento { get; set; }
}
