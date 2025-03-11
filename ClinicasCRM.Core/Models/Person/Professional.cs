using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.Models.Base;

namespace ClinicasCRM.Core.Models.Person;

public class Professional : BasePerson
{
    public ETipoProfissional Type { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public DateTime? Birthday { get; set; }

    public string ProfessionalNumber { get; set; } = string.Empty;
    public string ProfessionalCouncil { get; set; } = string.Empty;
    public string ProfessionalCouncilState { get; set; } = string.Empty;
    public List<Appointment.Appointment> Appointments { get; set; } = new();
}
