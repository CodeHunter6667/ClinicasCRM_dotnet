using ClinicasCRM.Core.Models.Paciente;
using System.Text.Json.Serialization;

namespace ClinicasCRM.Core.Dtos.Paciente;
public class HistoricoPacienteDto
{
    public long Id { get; set; }
    public string TratamentosAnteriores { get; set; } = string.Empty;
    public string Alergias { get; set; } = string.Empty;
    public string TratamentosOncologicos { get; set; } = string.Empty;
    public bool Hipertensao { get; set; }
    public bool ProblemaCardiaco { get; set; }
    public bool Marcapasso { get; set; }
    public bool ProtesesMetalicas { get; set; }
    public bool ProtesesDentarias { get; set; }
    public bool Epilepsia { get; set; }
    public bool FazTratamentoMedico { get; set; }
    public long ClienteId { get; set; }

    public HistoricoPacienteDto(HistoricoPaciente historico)
    {
        Id = historico.Id;
        TratamentosAnteriores = historico.TratamentosAnteriores;
        Alergias = historico.Alergias;
        TratamentosOncologicos = historico.TratamentosOncologicos;
        Hipertensao = historico.Hipertensao;
        ProblemaCardiaco = historico.ProblemaCardiaco;
        Marcapasso = historico.Marcapasso;
        ProtesesMetalicas = historico.ProtesesMetalicas;
        ProtesesDentarias = historico.ProtesesDentarias;
        Epilepsia = historico.Epilepsia;
        FazTratamentoMedico = historico.FazTratamentoMedico;
        ClienteId = historico.ClienteId;
    }

    [JsonConstructor]
    public HistoricoPacienteDto()
    {
        
    }
}
