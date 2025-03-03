using ClinicasCRM.Api.Services.Base.Interfaces;
using ClinicasCRM.Core.Dtos.Consulation;
using ClinicasCRM.Core.Models.Consulation;

namespace ClinicasCRM.Api.Services.Consulation.Interfaces;

public interface IBodyAnamnesisService : IBaseService<BodyAnamnesis>
{
    Task<List<BodyAnamnesisDto>> GetAllByClientAsync(long clientId, string userId);
    Task<List<BodyAnamnesisDto>> GetAllAsync(string userId);
    Task<BodyAnamnesisDto> GetByIdAsync(long id, string userId);
    Task<BodyAnamnesisDto> InsertAsync(BodyAnamnesisDto dto, string username);
    Task<BodyAnamnesisDto> UpdateAsync(long id, BodyAnamnesisDto dto, string username);
}
