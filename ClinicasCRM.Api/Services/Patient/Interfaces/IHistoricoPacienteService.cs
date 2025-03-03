using ClinicasCRM.Api.Servicos.Base.Interfaces;
using ClinicasCRM.Core.Dtos.Paciente;
using ClinicasCRM.Core.Models.Paciente;

namespace ClinicasCRM.Api.Servicos.Paciente.Interfaces;

public interface IHistoricoPacienteService : IServicoBase<PatientHistory>
{
    Task<List<PatientHistoryDto>> TodosAsync(string usuarioId);
    Task<PatientHistoryDto> ObterPorIdAsync(long id, string usuarioId);
    Task<PatientHistoryDto> AtualizarAsync(long id, PatientHistoryDto dto);
    Task<PatientHistoryDto> InserirAsync(PatientHistoryDto dto);
    Task<List<PatientHistoryDto>> ObterPorClienteAsync(long clienteId, string usuarioId);
}
