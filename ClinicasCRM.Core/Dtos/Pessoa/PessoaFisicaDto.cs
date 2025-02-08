using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.Models.Pessoa;
using System.Text.Json.Serialization;

namespace ClinicasCRM.Core.Dtos.Pessoa;
public class PessoaFisicaDto
{
    public long Id { get; set; }
    public string Telefone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public long EnderecoId { get; set; }
    public string NomeCompleto { get; set; } = string.Empty;
    public DateTime? DataNascimento { get; set; }
    public string Cpf { get; set; } = string.Empty;
    public EGenero Genero { get; set; }

    public PessoaFisicaDto(PessoaFisica pessoa)
    {
        Id = pessoa.Id;
        Telefone = pessoa.Telefone;
        Email = pessoa.Email;
        EnderecoId = pessoa.EnderecoId;
        NomeCompleto = pessoa.NomeCompleto;
        DataNascimento = pessoa.DataNascimento;
        Cpf = pessoa.Cpf;
        Genero = pessoa.Genero;
    }

    [JsonConstructor]
    public PessoaFisicaDto()
    {
    }
}
