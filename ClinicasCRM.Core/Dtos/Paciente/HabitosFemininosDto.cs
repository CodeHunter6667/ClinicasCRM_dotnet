using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.Models.Paciente;
using System.Text.Json.Serialization;

namespace ClinicasCRM.Core.Dtos.Paciente;
public class HabitosFemininosDto
{
    public long Id { get; set; }
    public bool AlimentacaoBalanceada { get; set; }
    public bool IntestinoRegular { get; set; }
    public bool SonoRegular { get; set; }
    public bool PraticaAtividadesFisicas { get; set; }
    public int DiasAtividadeFisica { get; set; }
    public bool Fumante { get; set; }
    public bool ConsomeBebidaAlcoolica { get; set; }
    public bool UsoAcidosNaPele { get; set; }
    public EFrequenciaConsumoAlcool ConsumoAlcool { get; set; }
    public string AcidosUsados { get; set; } = string.Empty;
    public bool UsaProtetorSolarDiario { get; set; }
    public bool CicloMenstrualRegular { get; set; }
    public bool UsoAnticoncepcionalRegular { get; set; }
    public bool Gestante { get; set; }
    public bool Lactante { get; set; }
    public bool TemFilhos { get; set; }
    public int QuantosFilhos { get; set; }
    public long ClienteId { get; set; }
    public string UsuarioId { get; set; }

    public HabitosFemininosDto(HabitosFemininos habitos)
    {
        Id = habitos.Id;
        AlimentacaoBalanceada = habitos.AlimentacaoBalanceada;
        IntestinoRegular = habitos.IntestinoRegular;
        SonoRegular = habitos.SonoRegular;
        PraticaAtividadesFisicas = habitos.PraticaAtividadesFisicas;
        DiasAtividadeFisica = habitos.DiasAtividadeFisica;
        Fumante = habitos.Fumante;
        ConsomeBebidaAlcoolica = habitos.ConsomeBebidaAlcoolica;
        UsoAcidosNaPele = habitos.UsoAcidosNaPele;
        ConsumoAlcool = habitos.ConsumoAlcool;
        AcidosUsados = habitos.AcidosUsados;
        UsaProtetorSolarDiario = habitos.UsaProtetorSolarDiario;
        CicloMenstrualRegular = habitos.CicloMenstrualRegular;
        UsoAnticoncepcionalRegular = habitos.UsoAnticoncepcionalRegular;
        Gestante = habitos.Gestante;
        Lactante = habitos.Lactante;
        TemFilhos = habitos.TemFilhos;
        QuantosFilhos = habitos.QuantosFilhos;
        ClienteId = habitos.ClienteId;
        UsuarioId = habitos.UsuarioId;
    }

    [JsonConstructor]
    public HabitosFemininosDto()
    {
        
    }
}
