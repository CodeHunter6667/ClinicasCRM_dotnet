using ClinicasCRM.Api.Servicos.Base.Interfaces;
using ClinicasCRM.Core.Dtos.Consulta;
using ClinicasCRM.Core.Models.Consulta;

namespace ClinicasCRM.Api.Servicos.Consulta.Interfaces;

public interface IAnamneseFacialService : IServicoBase<AnamneseFacial>
{
    Task<AnamneseFacialDto> InserirAsync(AnamneseFacialDto dto);
    Task<List<AnamneseFacialDto>> TodosAsync(string usuarioId);
    Task<List<AnamneseFacialDto>> TodosPorClienteAsync(long clienteId, string usuarioId);
    Task<AnamneseFacialDto> ObterPorIdAsync(long id, string usuarioId);
    Task<AnamneseFacialDto> AtualizarAsync(long id, AnamneseFacialDto dto);
}
