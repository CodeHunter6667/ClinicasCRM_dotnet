using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.Models.Base;
using ClinicasCRM.Core.Models.Person;
using ClinicasCRM.Core.Models.Pessoa;

namespace ClinicasCRM.Core.Models.Appointment;
public class Appointment : BaseEntity
{
    public Individual Client { get; set; } = new();
    public long ClientId { get; set; }
    public string ProcedureRoom { get; set; } = string.Empty;
    public Procedure.Procedure Procedure{ get; set; } = new();
    public long ProcedureId { get; set; }
    public TimeSpan AppoitmentTime { get; set; }
    public DateTime AppoitmentDate { get; set; }
    public long ProfessionalId { get; set; }
    public Professional Professional { get; set; }
    public EStatusAtendimento AppoitmentStatus { get; set; }
}
