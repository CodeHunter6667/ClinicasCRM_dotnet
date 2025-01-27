using ClinicasCRM.Core.Models.Agendamento;
using ClinicasCRM.Core.Models.Avaliacao;
using ClinicasCRM.Core.Models.Consulta;
using ClinicasCRM.Core.Models.Paciente;
using ClinicasCRM.Core.Models.Pessoa;
using ClinicasCRM.Core.Models.Procedimento;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ClinicasCRM.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<PessoaFisica> PessoasFisica { get; set; }
    public DbSet<PessoaJuridica> PessoasJuridica { get; set; }
    public DbSet<Procedimento> Procedimentos { get; set; }
    public DbSet<Habitos> Habitos { get; set; }
    public DbSet<HabitosFemininos> HabitosFemininos { get; set; }
    public DbSet<Medidas> Medidas { get; set; }
    public DbSet<Anamnese> Anamneses { get; set; }
    public DbSet<AnamneseCorporal> AnamnesesCorporal { get; set; }
    public DbSet<AnamneseFacial> AnamnesesFacial { get; set; }
    public DbSet<AvaliacaoCorporal> AvaliacoesCorporal { get; set; }
    public DbSet<AvaliacaoFacial> AvaliacoesFacial { get; set; }
    public DbSet<Agendamento> Agendamentos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
