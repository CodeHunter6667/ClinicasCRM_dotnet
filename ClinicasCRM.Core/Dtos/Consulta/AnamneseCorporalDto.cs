using ClinicasCRM.Core.Models.Consulta;
using System.Text.Json.Serialization;

namespace ClinicasCRM.Core.Dtos.Consulta;

public class AnamneseCorporalDto
{
    public long Id { get; set; }
    public bool EstaSalva { get; set; }
    public string PrincipaisQueixas { get; set; } = string.Empty;
    public long MedidasId { get; set; }
    public string AnotacoesTratamentoEscolhido { get; set; } = string.Empty;
    public DateTime DataAvaliacao { get; set; } = DateTime.Now;
    public string Observacoes { get; set; } = string.Empty;
    public string UsuarioId { get; set; } = string.Empty;
    public long ClienteId { get; set; }

    public AnamneseCorporalDto(AnamneseCorporal anamnese)
    {
        Id = anamnese.Id;
        EstaSalva = anamnese.EstaSalva;
        PrincipaisQueixas = anamnese.PrincipaisQueixas;
        MedidasId = anamnese.MedidasId;
        AnotacoesTratamentoEscolhido = anamnese.AnotacoesTratamentoEscolhido;
        DataAvaliacao = anamnese.DataAvaliacao;
        Observacoes = anamnese.Observacoes;
        ClienteId = anamnese.ClienteId;
        UsuarioId = anamnese.UsuarioId;
    }

    [JsonConstructor]
    public AnamneseCorporalDto()
    {
        
    }
}
