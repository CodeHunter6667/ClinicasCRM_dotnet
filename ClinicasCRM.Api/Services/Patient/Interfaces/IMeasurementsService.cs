using ClinicasCRM.Api.Services.Base.Interfaces;
using ClinicasCRM.Core.Dtos.Patient;
using ClinicasCRM.Core.Models.Patient;

namespace ClinicasCRM.Api.Services.Patient.Interfaces;

public interface IMeasurementsService : IBaseService<Measurements>
{
    Task<List<MeasurementsDto>> GetByClientAsync(long clientId, string userId);
    Task<MeasurementsDto> GetByIdAsync(long id, string userId);
    Task<List<MeasurementsDto>> GetAllAsync(string userId);
    Task<MeasurementsDto> InsertAsync(MeasurementsDto dto, string username, string userId);
    Task<MeasurementsDto> UpdateAsync(long id, MeasurementsDto dto, string username, string userId);
}
