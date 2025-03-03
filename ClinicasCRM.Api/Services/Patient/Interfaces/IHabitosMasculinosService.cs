using System.Security.Claims;
using ClinicasCRM.Api.Servicos.Base.Interfaces;
using ClinicasCRM.Core.Dtos.Paciente;
using ClinicasCRM.Core.Models.Paciente;

namespace ClinicasCRM.Api.Servicos.Paciente.Interfaces;

public interface IHabitosMasculinosService : IServicoBase<MaleHabits>
{
    Task<List<MaleHabitsDto>> TodosAsync(string usuarioId);
    Task<MaleHabitsDto> ObterPorIdAsync(long id, string usuarioId);
    Task<MaleHabitsDto> AtualizarAsync(long id, MaleHabitsDto dto);
    Task<MaleHabitsDto> InserirAsync(MaleHabitsDto dto);
    Task<List<MaleHabitsDto>> ObterPorClienteAsync(long clienteId, string usuarioId);
}
