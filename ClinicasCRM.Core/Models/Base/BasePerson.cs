using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.ValueObjects;

namespace ClinicasCRM.Core.Models.Base;
public class BasePerson : BaseEntity
{
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public long AddressId { get; set; }
    public Address Address { get; set; } = new();
    public ETipoCadastro RecordType { get; set; }
}
