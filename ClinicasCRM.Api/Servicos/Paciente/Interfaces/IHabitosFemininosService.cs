using ClinicasCRM.Api.Servicos.Base.Interfaces;
using ClinicasCRM.Core.Dtos.Paciente;
using ClinicasCRM.Core.Models.Paciente;

namespace ClinicasCRM.Api.Servicos.Paciente.Interfaces;

public interface IHabitosFemininosService : IServicoBase<HabitosFemininos>
{
    Task<List<HabitosFemininosDto>> TodosAsync(string usuarioId);
    Task<HabitosFemininosDto> ObterPorIdAsync(long id, string usuarioId);
    Task<List<HabitosFemininosDto>> ObterPorCliente(long clienteId, string usuarioId);
    Task<HabitosFemininosDto> AtualizarAsync(long id, HabitosFemininosDto dto);
    Task<HabitosFemininosDto> InserirAsync(HabitosFemininosDto dto);
}
