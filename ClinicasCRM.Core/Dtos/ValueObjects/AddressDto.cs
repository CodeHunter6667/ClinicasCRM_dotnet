using ClinicasCRM.Core.ValueObjects;
using System.Text.Json.Serialization;

namespace ClinicasCRM.Core.Dtos.ValueObjects;
public class AddressDto
{
    public long Id { get; set; }
    public string Street { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public string Neighborhood { get; set; } = string.Empty;
    public string Complement { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public string UserId { get; set; }

    public AddressDto(Address address)
    {
        Id = address.Id;
        Street = address.Street;
        Number = address.Number;
        Neighborhood = address.Neighborhood;
        Complement = address.Complement;
        City = address.City;
        State = address.State;
        ZipCode = address.ZipCode;
    }

    [JsonConstructor]
    public AddressDto()
    {
        
    }
}
