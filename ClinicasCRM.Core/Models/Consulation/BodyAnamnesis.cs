using ClinicasCRM.Core.Models.Patient;

namespace ClinicasCRM.Core.Models.Consulation;
public class BodyAnamnesis : Anamnesis
{
    public string MainComplaints { get; set; } = string.Empty;
    public Measurements Measurement { get; set; } = new();
    public long MeasurementId { get; set; }
    public string ChosenTreatmentNotes { get; set; } = string.Empty;
    public DateTime AssessmentDate { get; set; } = DateTime.Now;
    public string Notes { get; set; } = string.Empty;
}
