using ClinicasCRM.Api.Services.Base.Interfaces;
using ClinicasCRM.Core.Dtos.Patient;
using ClinicasCRM.Core.Models.Patient;

namespace ClinicasCRM.Api.Services.Patient.Interfaces;

public interface IFemaleHabitsService : IBaseService<FemaleHabits>
{
    Task<List<FemaleHabitsDto>> GetAllAsync(string userId);
    Task<FemaleHabitsDto> GetByIdAsync(long id, string userId);
    Task<List<FemaleHabitsDto>> GetByClientAsync(long clientId, string userId);
    Task<FemaleHabitsDto> UpdateAsync(long id, FemaleHabitsDto dto, string username, string userId);
    Task<FemaleHabitsDto> InsertAsync(FemaleHabitsDto dto, string username, string userId);
}
