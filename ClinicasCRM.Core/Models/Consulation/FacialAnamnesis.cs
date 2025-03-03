using ClinicasCRM.Core.Enums;

namespace ClinicasCRM.Core.Models.Consulation;
public class FacialAnamnesis : Anamnesis
{
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
}
