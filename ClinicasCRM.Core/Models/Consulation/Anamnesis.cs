using ClinicasCRM.Core.Models.Base;
using ClinicasCRM.Core.Models.Person;

namespace ClinicasCRM.Core.Models.Consulation;
public class Anamnesis : BaseEntity
{
    public Individual Client { get; set; } = new ();
    public long ClientId { get; set; }
}
