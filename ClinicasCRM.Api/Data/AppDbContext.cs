using ClinicasCRM.Core.Models.Appointment;
using ClinicasCRM.Core.Models.Consulation;
using ClinicasCRM.Core.Models.Patient;
using ClinicasCRM.Core.Models.Person;
using ClinicasCRM.Core.Models.Procedure;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ClinicasCRM.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Individual> Individuals { get; set; }
    public DbSet<LegalEntity> LegalEntities { get; set; }
    public DbSet<Procedure> Procedures { get; set; }
    public DbSet<MaleHabits> MaleHabits { get; set; }
    public DbSet<FemaleHabits> FemaleHabits { get; set; }
    public DbSet<PatientHistory> PatientHistories { get; set; }
    public DbSet<Measurements> Measurements { get; set; }
    public DbSet<BodyAnamnesis> BodyAnamnesis { get; set; }
    public DbSet<FacialAnamnesis> FacialAnamnesis { get; set; }
    public DbSet<Appointment> Appoitments { get; set; }
    public DbSet<Professional> Professionals { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
