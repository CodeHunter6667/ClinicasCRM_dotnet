using ClinicasCRM.Core.Models.Base;
using ClinicasCRM.Core.Models.Paciente;
using ClinicasCRM.Core.Models.Pessoa;

namespace ClinicasCRM.Core.Models.Consulta;
public class Anamnese : EntidadeBase
{
    public PessoaFisica Cliente { get; set; } = new ();
    public long ClienteId { get; set; }
}
