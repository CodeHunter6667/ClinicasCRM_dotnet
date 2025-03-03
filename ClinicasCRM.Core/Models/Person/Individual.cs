using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.Models.Base;
using ClinicasCRM.Core.Models.Consulation;
using ClinicasCRM.Core.Models.Patient;

namespace ClinicasCRM.Core.Models.Person;
public class Individual : BasePerson
{
    public string Name { get; set; } = string.Empty;
    public DateTime? Birthdate { get; set; }
    public int? Age { get 
        {
            var today = DateTime.Today;
            var age = today.Year - Birthdate.Value.Year;
            if (Birthdate.Value.Date > today.AddYears(-age)) age--;
            return age;
        } }
    public string Cpf { get; set; } = string.Empty;
    public EGenero Gender { get; set; }
    public List<Appointment.Appointment> Appointments { get; set; } = new();
    public List<BodyAnamnesis> BodyAnamneses { get; set; } = new();
    public List<FacialAnamnesis> FacialAnamneses { get; set; } = new();
    public List<PatientHistory> PatientHistories { get; set; } = new();
    public List<Measurements> Measurements { get; set; } = new();
    public List<MaleHabits> MaleHabits { get; set; } = new();
    public List<FemaleHabits> FemaleHabits { get; set; } = new();
}
