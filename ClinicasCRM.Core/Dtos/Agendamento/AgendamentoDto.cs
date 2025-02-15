using ClinicasCRM.Core.Enums;
using System.Text.Json.Serialization;

namespace ClinicasCRM.Core.Dtos.Agendamento;

public class AgendamentoDto
{
    public long Id { get; set; }
    public long ClienteId { get; set; }
    public string SalaAtendimento { get; set; } = string.Empty;
    public long ProcedimentoId { get; set; }
    public TimeSpan HoraAtendimento { get; set; }
    public DateTime DataAtendimento { get; set; }
    public string Profissional { get; set; } = string.Empty;
    public EStatusAtendimento StatusAtendimento { get; set; }

    public AgendamentoDto(Models.Agendamento.Agendamento agendamento)
    {
        Id = agendamento.Id;
        ClienteId = agendamento.ClienteId;
        SalaAtendimento = agendamento.SalaAtendimento;
        ProcedimentoId = agendamento.ProcedimentoId;
        HoraAtendimento = agendamento.HoraAtendimento;
        DataAtendimento = agendamento.DataAtendimento;
        Profissional = agendamento.Profissional;
        StatusAtendimento = agendamento.StatusAtendimento;
    }

    [JsonConstructor]
    public AgendamentoDto()
    {
        
    }
}
