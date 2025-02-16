using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.Models.Consulta;
using System.Text.Json.Serialization;

namespace ClinicasCRM.Core.Dtos.Consulta;

public class AnamneseFacialDto
{
    public long Id { get; set; }
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
    public string UsuarioId { get; set; } = string.Empty;
    public long ClienteId { get; set; }

    public AnamneseFacialDto(AnamneseFacial anamnese)
    {
        Id = anamnese.Id;
        PrincipaisQueixas = anamnese.PrincipaisQueixas;
        PresencaManchasPigmentaresRelacionadasMelanina = anamnese.PresencaManchasPigmentaresRelacionadasMelanina;
        PresencasManchasAlteracaoVascular = anamnese.PresencasManchasAlteracaoVascular;
        FormacoesSolidas = anamnese.FormacoesSolidas;
        FormacoesComConteudoLiquido = anamnese.FormacoesComConteudoLiquido;
        LesoesDePele = anamnese.LesoesDePele;
        SequelasOuCicatrizes = anamnese.SequelasOuCicatrizes;
        AlteracoesPelosFaciais = anamnese.AlteracoesPelosFaciais;
        AlteracoesQueratinizacao = anamnese.AlteracoesQueratinizacao;
        ClassificacaoCutanea = anamnese.ClassificacaoCutanea;
        ClassificacaoEspessura = anamnese.ClassificacaoEspessura;
        ClassificacaoOleosidade = anamnese.ClassificacaoOleosidade;
        ClassificacaoSensibilidade = anamnese.ClassificacaoSensibilidade;
        Observacoes = anamnese.Observacoes;
        ClienteId = anamnese.ClienteId;
        UsuarioId = anamnese.UsuarioId;
    }

    [JsonConstructor]
    public AnamneseFacialDto()
    {
        
    }
}
