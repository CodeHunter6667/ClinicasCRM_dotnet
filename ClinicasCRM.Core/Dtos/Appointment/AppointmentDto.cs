using ClinicasCRM.Core.Enums;
using System.Text.Json.Serialization;

namespace ClinicasCRM.Core.Dtos.Appointment;

public class AppointmentDto
{
    public long Id { get; set; }
    public long ClientId { get; set; }
    public string ProcedureRoom { get; set; } = string.Empty;
    public long ProcedureId { get; set; }
    public TimeSpan AppoitmentTime { get; set; }
    public DateTime AppoitmentDate { get; set; }
    public long ProfessionalId { get; set; }
    public EStatusAtendimento AppoitmentStatus { get; set; }
    public string UserId { get; set; } = string.Empty;

    public AppointmentDto(Models.Appointment.Appointment appointment)
    {
        Id = appointment.Id;
        ClientId = appointment.ClientId;
        ProcedureRoom = appointment.ProcedureRoom;
        ProcedureId = appointment.ProcedureId;
        AppoitmentTime = appointment.AppoitmentTime;
        AppoitmentDate = appointment.AppoitmentDate;
        ProfessionalId = appointment.ProfessionalId;
        AppoitmentStatus = appointment.AppoitmentStatus;
        UserId = appointment.UserId;
    }

    [JsonConstructor]
    public AppointmentDto()
    {
    }
}