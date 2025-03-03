using System.Text.Json.Serialization;
using ClinicasCRM.Core.Enums;

namespace ClinicasCRM.Core.Dtos.Procedure;
public class ProcedureDto
{
    public long Id { get; set; }
    public bool IsSaved { get; set; }
    public string ProcedureName { get; set; } = string.Empty;
    public int DurationInMinutes { get; set; }
    public string EquipmentUsed { get; set; } = string.Empty;
    public string ConsumedProducts { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public EFormaPagamento PaymentMethod { get; set; }

    public ProcedureDto(Models.Procedure.Procedure procedure)
    {
        Id = procedure.Id;
        IsSaved = procedure.IsSaved;
        ProcedureName = procedure.ProcedureName;
        DurationInMinutes = procedure.DurationInMinutes;
        EquipmentUsed = procedure.EquipmentUsed;
        ConsumedProducts = procedure.ConsumedProducts;
        Price = procedure.Price;
        PaymentMethod = procedure.PaymentMethod;
    }

    [JsonConstructor]
    public ProcedureDto()
    {
        
    }
}
