using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.Models.Avaliacao;
using ClinicasCRM.Core.Models.Base;
using ClinicasCRM.Core.Models.Consulta;
using ClinicasCRM.Core.Models.Paciente;

namespace ClinicasCRM.Core.Models.Pessoa;
public class PessoaFisica : PessoaBase
{
    public string NomeCompleto { get; set; } = string.Empty;
    public DateTime? DataNascimento { get; set; }
    public int? Idade { get 
        {
            var dataAtual = DateTime.Today;
            var idade = dataAtual.Year - DataNascimento.Value.Year;
            if (DataNascimento.Value.Date > dataAtual.AddYears(-idade)) idade--;
            return idade;
        } }
    public string Cpf { get; set; } = string.Empty;
    public EGenero Genero { get; set; }
    public List<AvaliacaoCorporal> AvaliaçõesCorporais { get; set; } = new List<AvaliacaoCorporal>();
    public List<AvaliacaoFacial> AvaliacaoFaciais { get; set; } = new List<AvaliacaoFacial>();
    public List<Agendamento.Agendamento> Agendamentos { get; set; } = new List<Agendamento.Agendamento>();
    public List<AnamneseCorporal> AnamnesesCorporais { get; set; } = new();
    public List<AnamneseFacial> AnamneseFaciais { get; set; } = new();
    public List<HistoricoPaciente> Historicos { get; set; } = new();
    public List<Medidas> Medidas { get; set; } = new();
    public List<HabitosMasculinos> HabitosMasculinos { get; set; } = new();
    public List<HabitosFemininos> HabitosFemininos { get; set; } = new();
}
