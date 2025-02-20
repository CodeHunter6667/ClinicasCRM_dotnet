using System.Security.Claims;
using ClinicasCRM.Api.Servicos.Base.Interfaces;
using ClinicasCRM.Core.Dtos.Paciente;
using ClinicasCRM.Core.Models.Paciente;

namespace ClinicasCRM.Api.Servicos.Paciente.Interfaces;

public interface IHabitosFemininosService : IServicoBase<HabitosFemininos>
{
    Task<HabitosFemininosDto> TodosAsync(ClaimsPrincipal usuario);
    Task<HabitosFemininosDto> ObterPorIdAsync(long id, string usuarioId);
    Task<HabitosFemininosDto> AtualizarAsync(long id, HabitosFemininosDto dto);
    Task<HabitosFemininosDto> InserirAsync(HabitosFemininosDto dto);
}
