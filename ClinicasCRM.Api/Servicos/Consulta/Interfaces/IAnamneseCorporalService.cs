using ClinicasCRM.Api.Servicos.Base.Interfaces;
using ClinicasCRM.Core.Dtos.Consulta;
using ClinicasCRM.Core.Models.Consulta;

namespace ClinicasCRM.Api.Servicos.Consulta.Interfaces;

public interface IAnamneseCorporalService : IServicoBase<AnamneseCorporal>
{
    Task<List<AnamneseCorporalDto>> TodosPorCliente(long clienteId);
    Task<AnamneseCorporalDto> ObterPorId(long id);
}
