using System.Security.Claims;
using ClinicasCRM.Api.Servicos.Base.Interfaces;
using ClinicasCRM.Core.Dtos.Paciente;
using ClinicasCRM.Core.Models.Paciente;

namespace ClinicasCRM.Api.Servicos.Paciente.Interfaces;

public interface IHabitosMasculinosService : IServicoBase<HabitosMasculinos>
{
    Task<List<HabitosMasculinosDto>> TodosAsync(string usuarioId);
    Task<HabitosMasculinosDto> ObterPorIdAsync(long id, string usuarioId);
    Task<HabitosMasculinosDto> AtualizarAsync(long id, HabitosMasculinosDto dto);
    Task<HabitosMasculinosDto> InserirAsync(HabitosMasculinosDto dto);
    Task<List<HabitosMasculinosDto>> ObterPorClienteAsync(long clienteId, string usuarioId);
}
