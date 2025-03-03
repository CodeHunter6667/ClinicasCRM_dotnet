using System.Text.Json.Serialization;
using ClinicasCRM.Core.Models.Consulation;

namespace ClinicasCRM.Core.Dtos.Consulation;

public class BodyAnamnesisDto
{
    public long Id { get; set; }
    public bool IsSaved { get; set; }
    public string MainComplaints { get; set; } = string.Empty;
    public long MeasurementId { get; set; }
    public string ChosenTreatmentNotes { get; set; } = string.Empty;
    public DateTime AssessmentDate { get; set; } = DateTime.Now;
    public string Notes { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty;
    public long ClientId { get; set; }

    public BodyAnamnesisDto(BodyAnamnesis anamnese)
    {
        Id = anamnese.Id; 
        IsSaved = anamnese.IsSaved;
        MainComplaints = anamnese.MainComplaints;
        MeasurementId = anamnese.MeasurementId;
        ChosenTreatmentNotes = anamnese.ChosenTreatmentNotes;
        AssessmentDate = anamnese.AssessmentDate;
        Notes = anamnese.Notes;
        ClientId = anamnese.ClientId;
        UserId = anamnese.UserId;
    }

    [JsonConstructor]
    public BodyAnamnesisDto()
    {
        
    }
}
