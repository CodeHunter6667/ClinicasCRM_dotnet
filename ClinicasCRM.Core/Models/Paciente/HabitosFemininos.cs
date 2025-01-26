namespace ClinicasCRM.Core.Models.Paciente;
public class HabitosFemininos : Habitos
{
    public bool CicloMenstrualRegular { get; set; }
    public bool UsoAnticoncepcionalRegular { get; set; }
    public bool Gestante { get; set; }
    public bool Lactante { get; set; }
    public bool TemFilhos { get; set; }
    public int QuantosFilhos { get; set; }
}
