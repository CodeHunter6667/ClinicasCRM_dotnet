using ClinicasCRM.Api.Repositorios.Agendamento;
using ClinicasCRM.Api.Servicos.Agendamento.Interfaces;
using ClinicasCRM.Api.Servicos.Base;

namespace ClinicasCRM.Api.Servicos.Agendamento;

public class AgendamentoService : ServicoBase<ClinicasCRM.Core.Models.Agendamento.Agendamento, AgendamentoRepositorio>, IAgendamentoService
{
}
