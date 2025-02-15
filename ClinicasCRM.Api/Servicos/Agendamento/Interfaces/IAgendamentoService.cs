using ClinicasCRM.Api.Servicos.Base.Interfaces;
using ClinicasCRM.Core.Common;
using ClinicasCRM.Core.Dtos.Agendamento;

namespace ClinicasCRM.Api.Servicos.Agendamento.Interfaces;

public interface IAgendamentoService : IServicoBase<ClinicasCRM.Core.Models.Agendamento.Agendamento>
{
    Task<List<AgendamentoDto>> TodosPorClienteAsync(long clienteId, ParametrosPaginacao parametrosPaginacao);
    Task<List<AgendamentoDto>> TodosAsync(ParametrosPaginacao parametrosPaginacao);
    Task<List<AgendamentoDto>> TodosPorDataAsync(DateTime data, ParametrosPaginacao parametrosPaginacao);
    Task<List<AgendamentoDto>> TodosPorDataAsync(DateTime dataInicial, DateTime dataFinal);
    Task<AgendamentoDto> ObterPorIdAsync(long id);
    Task<AgendamentoDto> InserirAsync(AgendamentoDto agendamentoDto);
    Task<AgendamentoDto> AtualizarAsync(AgendamentoDto agendamentoDto);
}
