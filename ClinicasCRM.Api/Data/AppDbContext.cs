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

    public DbSet<PessoaFisica> PessoasFisicas { get; set; }
    public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }
    public DbSet<Procedimento> Procedimentos { get; set; }
    public DbSet<HabitosMasculinos> HabitosMasculinos { get; set; }
    public DbSet<HabitosFemininos> HabitosFemininos { get; set; }
    public DbSet<Medidas> Medidas { get; set; }
    public DbSet<AnamneseCorporal> AnamnesesCorporais { get; set; }
    public DbSet<AnamneseFacial> AnamnesesFaciais { get; set; }
    public DbSet<AvaliacaoCorporal> AvaliacoesCorporais { get; set; }
    public DbSet<AvaliacaoFacial> AvaliacoesFaciais { get; set; }
    public DbSet<Agendamento> Agendamentos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
