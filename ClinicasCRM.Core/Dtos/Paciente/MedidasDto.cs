using ClinicasCRM.Core.Models.Paciente;
using System.Text.Json.Serialization;

namespace ClinicasCRM.Core.Dtos.Paciente;
public class MedidasDto
{
    public long Id { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }
    public double Busto { get; set; }
    public double BracoEsquerdo { get; set; }
    public double BracoDireito { get; set; }
    public double AbdomenSuperior { get; set; }
    public double Quadril { get; set; }
    public double CoxaEsquerda { get; set; }
    public double CoxaDireita { get; set; }
    public double PanturrilhaEsquerda { get; set; }
    public double PanturrilhaDireita { get; set; }
    public DateTime DataMedicao { get; set; }
    public long ClienteId { get; set; }

    public MedidasDto(Medidas medidas)
    {
        Id = medidas.Id;
        Peso = medidas.Peso;
        Altura = medidas.Altura;
        Busto = medidas.Busto;
        BracoEsquerdo = medidas.BracoEsquerdo;
        BracoDireito = medidas.BracoDireito;
        AbdomenSuperior = medidas.AbdomenSuperior;
        Quadril = medidas.Quadril;
        CoxaEsquerda = medidas.CoxaEsquerda;
        CoxaDireita = medidas.CoxaDireita;
        PanturrilhaEsquerda = medidas.PanturrilhaEsquerda;
        PanturrilhaDireita = medidas.PanturrilhaDireita;
        DataMedicao = medidas.DataMedicao;
        ClienteId = medidas.ClienteId;
    }

    [JsonConstructor]
    public MedidasDto()
    {
        
    }
}
