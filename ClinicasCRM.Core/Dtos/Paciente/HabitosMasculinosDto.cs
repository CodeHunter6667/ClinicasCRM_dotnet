using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.Models.Paciente;
using System.Text.Json.Serialization;

namespace ClinicasCRM.Core.Dtos.Paciente;
public class HabitosMasculinosDto
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
    public long ClienteId { get; set; }
    public string UsuarioId { get; set; }

    public HabitosMasculinosDto(HabitosMasculinos habitos)
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
        ClienteId = habitos.ClienteId;
        UsuarioId = habitos.UsuarioId;
    }

    [JsonConstructor]
    public HabitosMasculinosDto()
    {
        
    }
}
