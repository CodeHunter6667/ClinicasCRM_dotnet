using ClinicasCRM.Core.Enums;
using System.Text.Json.Serialization;
using ClinicasCRM.Core.Models.Person;

namespace ClinicasCRM.Core.Dtos.Person;
public class IndividualDto
{
    public long Id { get; set; }
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public long AddressId { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime? Birthdate { get; set; }
    public string Cpf { get; set; } = string.Empty;
    public EGenero Gender { get; set; }

    public IndividualDto(Individual pessoa)
    {
        Id = pessoa.Id;
        Phone = pessoa.Phone;
        Email = pessoa.Email;
        AddressId = pessoa.AddressId;
        Name = pessoa.Name;
        Birthdate = pessoa.Birthdate;
        Cpf = pessoa.Cpf;
        Gender = pessoa.Gender;
    }

    [JsonConstructor]
    public IndividualDto()
    {
    }
}
