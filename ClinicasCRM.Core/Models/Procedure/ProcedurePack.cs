using ClinicasCRM.Core.Models.Base;

namespace ClinicasCRM.Core.Models.Procedure;

public class ProcedurePack : BaseEntity
{
    public string PackName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<Procedure> Procedures { get; set; } = new();
    public decimal Price { get; set; }
    public bool Active { get; set; }
}
