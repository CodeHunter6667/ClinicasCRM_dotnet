using ClinicasCRM.Api.Services.Base.Interfaces;
using ClinicasCRM.Core.Dtos.Patient;
using ClinicasCRM.Core.Models.Patient;

namespace ClinicasCRM.Api.Services.Patient.Interfaces;

public interface IPatientHistoryService : IBaseService<PatientHistory>
{
    Task<List<PatientHistoryDto>> GetAllAsync(string userId);
    Task<PatientHistoryDto> GetByIdAsync(long id, string userId);
    Task<PatientHistoryDto> UpdateAsync(long id, PatientHistoryDto dto, string username, string userId);
    Task<PatientHistoryDto> InsertAsync(PatientHistoryDto dto, string username, string userId);
    Task<List<PatientHistoryDto>> GetByClientAsync(long clientId, string userId);
}
