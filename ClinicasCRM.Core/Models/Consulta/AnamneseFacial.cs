using ClinicasCRM.Core.Enums;

namespace ClinicasCRM.Core.Models.Consulta;
public class AnamneseFacial : Anamnese
{
    public string PrincipaisQueixas { get; set; } = string.Empty;
    public bool PresencaManchasPigmentaresRelacionadasMelanina { get; set; }
    public bool PresencasManchasAlteracaoVascular { get; set; }
    public bool FormacoesSolidas { get; set; }
    public bool FormacoesComConteudoLiquido { get; set; }
    public bool LesoesDePele { get; set; }
    public bool SequelasOuCicatrizes { get; set; }
    public bool AlteracoesPelosFaciais { get; set; }
    public bool AlteracoesQueratinizacao { get; set; }
    public EClassificacaoCutanea ClassificacaoCutanea { get; set; }
    public EClassificacaoEspessura ClassificacaoEspessura { get; set; }
    public EClassificacaoOleosidade ClassificacaoOleosidade { get; set; }
    public EClassificacaoSensibilidade ClassificacaoSensibilidade { get; set; }
    public string Observacoes { get; set; } = string.Empty;
}
