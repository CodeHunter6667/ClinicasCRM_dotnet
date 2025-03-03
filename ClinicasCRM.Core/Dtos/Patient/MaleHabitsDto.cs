using ClinicasCRM.Core.Enums;
using System.Text.Json.Serialization;
using ClinicasCRM.Core.Models.Patient;

namespace ClinicasCRM.Core.Dtos.Patient;
public class MaleHabitsDto
{
    public long Id { get; set; }
    public bool BalencedDiet { get; set; }
    public bool RegularBowels { get; set; }
    public bool RegularSleep { get; set; }
    public bool PracticesPhysicalActivities { get; set; }
    public int? PhysicalActivityDaysPerWeek { get; set; }
    public bool Smoker { get; set; }
    public bool ConsumesAlcoholicBeverage { get; set; }
    public bool UseAcidOnSkin { get; set; }
    public EFrequenciaConsumoAlcool AlcoholConsumptionFrequency { get; set; }
    public string AcidsUsed { get; set; } = string.Empty;
    public bool UsesDailySunscreen { get; set; }
    public long ClientId { get; set; }
    public string UserId { get; set; }

    public MaleHabitsDto(MaleHabits habitos)
    {
        Id = habitos.Id;
        BalencedDiet = habitos.BalencedDiet;
        RegularBowels = habitos.RegularBowels;
        RegularSleep = habitos.RegularSleep;
        PracticesPhysicalActivities = habitos.PracticesPhysicalActivities;
        PhysicalActivityDaysPerWeek = habitos.PhysicalActivityDaysPerWeek;
        Smoker = habitos.Smoker;
        ConsumesAlcoholicBeverage = habitos.ConsumesAlcoholicBeverage;
        UseAcidOnSkin = habitos.UseAcidOnSkin;
        AlcoholConsumptionFrequency = habitos.AlcoholConsumptionFrequency;
        AcidsUsed = habitos.AcidsUsed;
        UsesDailySunscreen = habitos.UsesDailySunscreen;
        ClientId = habitos.ClientId;
        UserId = habitos.UserId;
    }

    [JsonConstructor]
    public MaleHabitsDto()
    {
        
    }
}
