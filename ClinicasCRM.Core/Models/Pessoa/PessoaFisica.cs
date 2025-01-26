using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.Models.Base;

namespace ClinicasCRM.Core.Models.Pessoa;
public class PessoaFisica : PessoaBase
{
    public string NomeCompleto { get; set; } = string.Empty;
    public DateTime DataNascimento { get; set; }
    public int Idade { get 
        {
            var dataAtual = DateTime.Today;
            var idade = dataAtual.Year - DataNascimento.Year;
            if (DataNascimento.Date > dataAtual.AddYears(-idade)) idade--;
            return idade;
        } }
    public string Cpf { get; set; } = string.Empty;
    public EGenero Genero { get; set; }
}
