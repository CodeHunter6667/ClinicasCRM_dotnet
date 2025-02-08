using ClinicasCRM.Core.Models.Pessoa;
using System.Text.Json.Serialization;

namespace ClinicasCRM.Core.Dtos.Pessoa;
public class PessoaJuridicaDto
{
    public long Id { get; set; }
    public string Telefone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public long EnderecoId { get; set; }
    public string RazaoSocial { get; set; } = string.Empty;
    public string NomeFantasia { get; set; } = string.Empty;
    public string Cnpj { get; set; } = string.Empty;
    public string InscricaoEstadual { get; set; } = string.Empty;
    public string InscricaoMunicipal { get; set; } = string.Empty;

    public PessoaJuridicaDto(PessoaJuridica pessoa)
    {
        Id = pessoa.Id;
        Telefone = pessoa.Telefone;
        Email = pessoa.Email;
        EnderecoId = pessoa.EnderecoId;
        RazaoSocial = pessoa.RazaoSocial;
        NomeFantasia = pessoa.NomeFantasia;
        Cnpj = pessoa.Cnpj;
        InscricaoEstadual = pessoa.InscricaoEstadual;
        InscricaoMunicipal = pessoa.InscricaoMunicipal;
    }

    [JsonConstructor]
    public PessoaJuridicaDto()
    {
        
    }
}
