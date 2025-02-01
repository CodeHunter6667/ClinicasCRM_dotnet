using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.Models.Base;
using ClinicasCRM.Core.Models.Consulta;
using ClinicasCRM.Core.Models.Pessoa;

namespace ClinicasCRM.Core.Models.Avaliacao;
public class AvaliacaoFacial : EntidadeBase
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
    public PessoaFisica Cliente { get; set; } = new();
    public long ClienteId { get; set; }
    public List<AnamneseFacial> AnamnesesFaciais { get; set; } = new();
}
