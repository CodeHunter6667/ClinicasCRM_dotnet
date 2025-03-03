using ClinicasCRM.Api.Servicos.Base.Interfaces;
using ClinicasCRM.Core.Dtos.Paciente;
using ClinicasCRM.Core.Models.Paciente;

namespace ClinicasCRM.Api.Servicos.Paciente.Interfaces;

public interface IHabitosFemininosService : IServicoBase<HabitosFemininos>
{
    Task<List<FemaleHabitsDto>> TodosAsync(string usuarioId);
    Task<FemaleHabitsDto> ObterPorIdAsync(long id, string usuarioId);
    Task<List<FemaleHabitsDto>> ObterPorCliente(long clienteId, string usuarioId);
    Task<FemaleHabitsDto> AtualizarAsync(long id, FemaleHabitsDto dto);
    Task<FemaleHabitsDto> InserirAsync(FemaleHabitsDto dto);
}
