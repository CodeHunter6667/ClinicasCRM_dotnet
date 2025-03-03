using ClinicasCRM.Core.Models.Base;

namespace ClinicasCRM.Core.Models.Person;
public class LegalEntity : BasePerson
{
    public string CompanyName { get; set; } = string.Empty;
    public string TradeName { get; set; } = string.Empty;
    public string Cnpj { get; set; } = string.Empty;
    public string StateRegistration { get; set; } = string.Empty;
    public string CityRegistration { get; set; } = string.Empty;
}
