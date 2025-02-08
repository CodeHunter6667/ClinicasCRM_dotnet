using ClinicasCRM.Core.ValueObjects;
using System.Text.Json.Serialization;

namespace ClinicasCRM.Core.Dtos.ValueObjects;
public class EnderecoDto
{
    public long Id { get; set; }
    public string Logradouro { get; set; } = string.Empty;
    public string Numero { get; set; } = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public string Complemento { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string Uf { get; set; } = string.Empty;
    public string Cep { get; set; } = string.Empty;

    public EnderecoDto(Endereco endereco)
    {
        Id = endereco.Id;
        Logradouro = endereco.Logradouro;
        Numero = endereco.Numero;
        Bairro = endereco.Bairro;
        Complemento = endereco.Complemento;
        Cidade = endereco.Cidade;
        Uf = endereco.Uf;
        Cep = endereco.Cep;
    }

    [JsonConstructor]
    public EnderecoDto()
    {
        
    }
}
