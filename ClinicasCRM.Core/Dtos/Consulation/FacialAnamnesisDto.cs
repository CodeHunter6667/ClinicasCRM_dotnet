using ClinicasCRM.Core.Enums;
using System.Text.Json.Serialization;
using ClinicasCRM.Core.Models.Consulation;

namespace ClinicasCRM.Core.Dtos.Consulation;

public class FacialAnamnesisDto
{
    public long Id { get; set; }
    public string MainComplaints { get; set; } = string.Empty;
    public bool MelaninRelatedPigmentSpotsPresent { get; set; }
    public bool VascularAlterationSpotsPresent { get; set; }
    public bool SolidFormationsPresent { get; set; }
    public bool LiquidContentFormationsPresent { get; set; }
    public bool SkinLesionsPresent { get; set; }
    public bool SequelaeOrScarsPresent { get; set; }
    public bool FacialHairAlterationsPresent { get; set; }
    public bool KeratinizationAlterationsPresent { get; set; }
    public EClassificacaoCutanea SkinClassification { get; set; }
    public EClassificacaoEspessura SkinThicknessClassification { get; set; }
    public EClassificacaoOleosidade OilinessClassification { get; set; }
    public EClassificacaoSensibilidade SensitivityClassification { get; set; }
    public string Notes { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty;
    public long ClientId { get; set; }

    public FacialAnamnesisDto(FacialAnamnesis anamnese)
    {
        Id = anamnese.Id;
        MainComplaints = anamnese.MainComplaints;
        MelaninRelatedPigmentSpotsPresent = anamnese.MelaninRelatedPigmentSpotsPresent;
        VascularAlterationSpotsPresent = anamnese.VascularAlterationSpotsPresent;
        SolidFormationsPresent = anamnese.SolidFormationsPresent;
        LiquidContentFormationsPresent = anamnese.LiquidContentFormationsPresent;
        SkinLesionsPresent = anamnese.SkinLesionsPresent;
        SequelaeOrScarsPresent = anamnese.SequelaeOrScarsPresent;
        FacialHairAlterationsPresent = anamnese.FacialHairAlterationsPresent;
        KeratinizationAlterationsPresent = anamnese.KeratinizationAlterationsPresent;
        SkinClassification = anamnese.SkinClassification;
        SkinThicknessClassification = anamnese.SkinThicknessClassification;
        OilinessClassification = anamnese.OilinessClassification;
        SensitivityClassification = anamnese.SensitivityClassification;
        Notes = anamnese.Notes;
        ClientId = anamnese.ClientId;
        UserId = anamnese.UserId;
    }

    [JsonConstructor]
    public FacialAnamnesisDto()
    {
        
    }
}
