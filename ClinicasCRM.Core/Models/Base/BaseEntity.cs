namespace ClinicasCRM.Core.Models.Base;
public class BaseEntity
{
    public long Id { get; set; }
    public string CreatedBy { get; set; } = string.Empty;
    public bool IsSaved { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    public string UpdatedBy { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty;
}
