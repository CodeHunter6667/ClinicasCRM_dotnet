using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.Models.Base;

namespace ClinicasCRM.Core.Models.Procedure;

public class Procedure : BaseEntity
{
    public string ProcedureName { get; set; } = string.Empty;
    public int DurationInMinutes { get; set; }
    public string EquipmentUsed { get; set; } = string.Empty;
    public string ConsumedProducts { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public EFormaPagamento PaymentMethod { get; set; }
    public List<Appointment.Appointment> Appointments { get; set; } = new();
    public List<ProcedurePackProcedure> ProcedurePackProcedures { get; set; } = new();
}
