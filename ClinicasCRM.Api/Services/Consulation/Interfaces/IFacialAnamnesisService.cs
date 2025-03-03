using ClinicasCRM.Api.Services.Base.Interfaces;
using ClinicasCRM.Core.Dtos.Consulation;
using ClinicasCRM.Core.Models.Consulation;

namespace ClinicasCRM.Api.Services.Consulation.Interfaces;

public interface IFacialAnamnesisService : IBaseService<FacialAnamnesis>
{
    Task<FacialAnamnesisDto> InsertAsync(FacialAnamnesisDto dto, string username, string userId);
    Task<List<FacialAnamnesisDto>> GetAllAsync(string userId);
    Task<List<FacialAnamnesisDto>> GetAllByClientAsync(long clientId, string userId);
    Task<FacialAnamnesisDto> GetByIdAsync(long id, string userId);
    Task<FacialAnamnesisDto> UpdateAsync(long id, FacialAnamnesisDto dto, string username, string userId);
}
