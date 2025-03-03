using System.Text.Json.Serialization;
using ClinicasCRM.Core.Models.Patient;

namespace ClinicasCRM.Core.Dtos.Patient;
public class MeasurementsDto
{
    public long Id { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }
    public double Bust { get; set; }
    public double LeftArm { get; set; }
    public double RightArm { get; set; }
    public double UpperAbdomen { get; set; }
    public double Hip { get; set; }
    public double LeftThigh { get; set; }
    public double RightThigh { get; set; }
    public double LeftCalf { get; set; }
    public double RightCalf { get; set; }
    public DateTime MeasurementDate { get; set; }
    public long ClientId { get; set; }
    public string UserId { get; set; }

    public MeasurementsDto(Measurements medidas)
    {
        Id = medidas.Id;
        Weight = medidas.Weight;
        Height = medidas.Height;
        Bust = medidas.Bust;
        LeftArm = medidas.LeftArm;
        RightArm = medidas.RightArm;
        UpperAbdomen = medidas.UpperAbdomen;
        Hip = medidas.Hip;
        LeftThigh = medidas.LeftThigh;
        RightThigh = medidas.RightThigh;
        LeftCalf = medidas.LeftCalf;
        RightCalf = medidas.RightCalf;
        MeasurementDate = medidas.MeasurementDate;
        ClientId = medidas.ClientId;
        UserId = medidas.UserId;
    }

    [JsonConstructor]
    public MeasurementsDto()
    {
        
    }
}
