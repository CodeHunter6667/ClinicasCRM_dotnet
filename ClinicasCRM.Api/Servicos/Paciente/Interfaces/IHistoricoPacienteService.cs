using ClinicasCRM.Api.Servicos.Base.Interfaces;
using ClinicasCRM.Core.Dtos.Paciente;
using ClinicasCRM.Core.Models.Paciente;

namespace ClinicasCRM.Api.Servicos.Paciente.Interfaces;

public interface IHistoricoPacienteService : IServicoBase<HistoricoPaciente>
{
    Task<List<HistoricoPacienteDto>> TodosAsync(string usuarioId);
    Task<HistoricoPacienteDto> ObterPorIdAsync(long id, string usuarioId);
    Task<HistoricoPacienteDto> AtualizarAsync(long id, HistoricoPacienteDto dto);
    Task<HistoricoPacienteDto> InserirAsync(HistoricoPacienteDto dto);
    Task<List<HistoricoPacienteDto>> ObterPorClienteAsync(long clienteId, string usuarioId);
}
