using System.Text.Json.Serialization;
using ClinicasCRM.Core.Models.Patient;

namespace ClinicasCRM.Core.Dtos.Patient;
public class PatientHistoryDto
{
    public long Id { get; set; }
    public string PreviousTreatments { get; set; } = string.Empty;
    public string Allergies { get; set; } = string.Empty;
    public string OncologicalTreatments { get; set; } = string.Empty;
    public bool Hypertension { get; set; }
    public bool HeartProblem { get; set; }
    public bool Pacemaker { get; set; }
    public bool MetalProstheses { get; set; }
    public bool DentalProstheses { get; set; }
    public bool Epilepsy { get; set; }
    public bool UnderMedicalTreatment { get; set; }
    public long ClientId { get; set; }
    public string UserId { get; set; }

    public PatientHistoryDto(PatientHistory historico)
    {
        Id = historico.Id;
        PreviousTreatments = historico.PreviousTreatments;
        Allergies = historico.Allergies;
        OncologicalTreatments = historico.OncologicalTreatments;
        Hypertension = historico.Hypertension;
        HeartProblem = historico.HeartProblem;
        Pacemaker = historico.Pacemaker;
        MetalProstheses = historico.MetalProstheses;
        DentalProstheses = historico.DentalProstheses;
        Epilepsy = historico.Epilepsy;
        UnderMedicalTreatment = historico.UnderMedicalTreatment;
        ClientId = historico.ClientId;
        UserId = historico.UserId;
    }

    [JsonConstructor]
    public PatientHistoryDto()
    {
        
    }
}
