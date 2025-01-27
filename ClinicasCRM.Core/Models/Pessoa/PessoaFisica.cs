using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.Models.Avaliacao;
using ClinicasCRM.Core.Models.Base;
using ClinicasCRM.Core.Models.Consulta;

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
    public List<AvaliacaoCorporal> AvaliaçõesCorporais { get; set; } = new List<AvaliacaoCorporal>();
    public List<AvaliacaoFacial> AvaliacaoFaciais { get; set; } = new List<AvaliacaoFacial>();
    public List<Agendamento.Agendamento> Agendamentos { get; set; } = new List<Agendamento.Agendamento>();
    public List<Anamnese> Anamneses { get; set; } = new List<Anamnese>();
}
