using ClinicasCRM.Api.Services.Base.Interfaces;
using ClinicasCRM.Core.Dtos.Patient;
using ClinicasCRM.Core.Models.Patient;

namespace ClinicasCRM.Api.Services.Patient.Interfaces;

public interface IMaleHabitsService : IBaseService<MaleHabits>
{
    Task<List<MaleHabitsDto>> GetAllAsync(string userId);
    Task<MaleHabitsDto> GetByIdAsync(long id, string userId);
    Task<MaleHabitsDto> UpdateAsync(long id, MaleHabitsDto dto, string username, string userId);
    Task<MaleHabitsDto> InsertAsync(MaleHabitsDto dto, string username, string userId);
    Task<List<MaleHabitsDto>> GetByClientAsync(long clientId, string userId);
}
