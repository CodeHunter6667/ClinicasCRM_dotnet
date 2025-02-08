using ClinicasCRM.Core.Enums;
using System.Text.Json.Serialization;

namespace ClinicasCRM.Core.Dtos.Agendamento;

public class AgendamentoDto
{
    public long Id { get; set; }
    public long ClienteId { get; set; }
    public string SalaAtendimento { get; set; } = string.Empty;
    public long ProcedimentoId { get; set; }
    public int Duracao { get; set; }
    public DateTime DiaAtendimento { get; set; }
    public string Profissional { get; set; } = string.Empty;
    public EStatusAtendimento StatusAtendimento { get; set; }

    public AgendamentoDto(Models.Agendamento.Agendamento agendamento)
    {
        Id = agendamento.Id;
        ClienteId = agendamento.ClienteId;
        SalaAtendimento = agendamento.SalaAtendimento;
        ProcedimentoId = agendamento.ProcedimentoId;
        Duracao = agendamento.Duracao;
        DiaAtendimento = agendamento.DiaAtendimento;
        Profissional = agendamento.Profissional;
        StatusAtendimento = agendamento.StatusAtendimento;
    }

    [JsonConstructor]
    public AgendamentoDto()
    {
        
    }
}
