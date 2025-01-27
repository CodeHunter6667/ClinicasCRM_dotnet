using ClinicasCRM.Core.Models.Base;
using ClinicasCRM.Core.Models.Consulta;

namespace ClinicasCRM.Core.Models.Paciente;
public class HistoricoPaciente : EntidadeBase
{
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
    public List<Anamnese> Anamneses { get; set; } = new List<Anamnese>();
}
