namespace ClinicasCRM.Core.Models.Patient;
public class FemaleHabits : Habits
{
    public bool RegularMenstrualCycle { get; set; }
    public bool RegularContraceptiveUse { get; set; }
    public bool Pregnant { get; set; }
    public bool Breastfeeding { get; set; }
    public bool HasChildren { get; set; }
    public int? NumberOfChildren { get; set; }
}
