using ClinicasCRM.Api.Servicos.Base.Interfaces;
using ClinicasCRM.Core.Dtos.Consulta;
using ClinicasCRM.Core.Models.Consulta;

namespace ClinicasCRM.Api.Servicos.Consulta.Interfaces;

public interface IAnamneseCorporalService : IServicoBase<AnamneseCorporal>
{
    Task<List<AnamneseCorporalDto>> TodosPorCliente(long clienteId, string usuarioId);
    Task<List<AnamneseCorporalDto>> TodosAsync(string usuarioId);
    Task<AnamneseCorporalDto> ObterPorId(long id, string usuarioId);
    Task<AnamneseCorporalDto> InserirAsync(AnamneseCorporalDto anamneseCorporalDto);
    Task<AnamneseCorporalDto> AtualizarAsync(long id, AnamneseCorporalDto anamneseCorporalDto);
}
