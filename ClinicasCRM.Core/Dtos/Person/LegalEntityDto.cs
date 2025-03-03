using System.Text.Json.Serialization;
using ClinicasCRM.Core.Models.Person;

namespace ClinicasCRM.Core.Dtos.Person;
public class LegalEntityDto
{
    public long Id { get; set; }
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public long AddressId { get; set; }
    public string CompanyName { get; set; } = string.Empty;
    public string TradeName { get; set; } = string.Empty;
    public string Cnpj { get; set; } = string.Empty;
    public string StateRegistration { get; set; } = string.Empty;
    public string CityRegistration { get; set; } = string.Empty;

    public LegalEntityDto(LegalEntity pessoa)
    {
        Id = pessoa.Id;
        Phone = pessoa.Phone;
        Email = pessoa.Email;
        AddressId = pessoa.AddressId;
        CompanyName = pessoa.CompanyName;
        TradeName = pessoa.TradeName;
        Cnpj = pessoa.Cnpj;
        StateRegistration = pessoa.StateRegistration;
        CityRegistration = pessoa.CityRegistration;
    }

    [JsonConstructor]
    public LegalEntityDto()
    {
        
    }
}
