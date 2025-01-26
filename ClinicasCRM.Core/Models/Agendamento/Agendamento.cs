using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.Models.Base;
using ClinicasCRM.Core.Models.Pessoa;

namespace ClinicasCRM.Core.Models.Agendamento;
public class Agendamento : EntidadeBase
{
    public PessoaFisica Cliente { get; set; } = new();
    public string SalaAtendimento { get; set; } = string.Empty;
    public Procedimento.Procedimento Procedimento{ get; set; } = new();
    public int Duracao { get; set; }
    public DateTime DiaAtendimento { get; set; }
    public string Profissional { get; set; } = string.Empty;
    public EStatusAtendimento StatusAtendimento { get; set; }
}
