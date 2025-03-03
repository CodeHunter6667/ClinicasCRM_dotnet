using ClinicasCRM.Api.Services.Base.Interfaces;
using ClinicasCRM.Core.Dtos.Appointment;

namespace ClinicasCRM.Api.Services.Appointment.Interfaces;

public interface IAppointmentService : IBaseService<ClinicasCRM.Core.Models.Appointment.Appointment>
{
    Task<List<AppointmentDto>> GetAllByClientAsync(long clientId, string userId, int pageSize, int pageNumber);
    Task<List<AppointmentDto>> GetAllAsync(string userId, int pageSize, int pageNumber);
    Task<List<AppointmentDto>> GetAllByDateAsync(DateTime date, string userId, int pageSize, int pageNumber);
    Task<List<AppointmentDto>> GetAllByDateAsync(DateTime initialDate, DateTime endDate, string userId);
    Task<AppointmentDto> GetByIdAsync(long id, string userId);
    Task<AppointmentDto> InsertAsync(AppointmentDto dto, string username, string userId);
    Task<AppointmentDto> UpdateAsync(long id, AppointmentDto dto, string username, string userId);
}
