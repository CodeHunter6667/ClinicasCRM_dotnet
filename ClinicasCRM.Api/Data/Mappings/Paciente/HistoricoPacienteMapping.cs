using ClinicasCRM.Core.Models.Paciente;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Paciente;

public class HistoricoPacienteMapping : IEntityTypeConfiguration<HistoricoPaciente>
{
    public void Configure(EntityTypeBuilder<HistoricoPaciente> builder)
    {
        builder.ToTable("HistoricoPacientes");

        builder.HasKey(a => a.Id);

        builder.Property(a => a.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        builder.Property(x => x.UsuarioCriacao)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

        builder.Property(x => x.EstaSalva)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.DataCriacao)
            .IsRequired()
            .HasColumnType("TIMESTAMP");

        builder.Property(x => x.DataAlteracao)
            .HasColumnType("TIMESTAMP");

        builder.Property(x => x.UsuarioId)
            .IsRequired()
            .HasColumnType("BIGINT");

        builder.Property(x => x.TratamentosAnteriores)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(300);

        builder.Property(x => x.Alergias)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(255);

        builder.Property(x => x.TratamentosOncologicos)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(255);

        builder.Property(x => x.Hipertensao)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.ProblemaCardiaco)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.Marcapasso)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.ProtesesMetalicas)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.ProtesesDentarias)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.Epilepsia)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.FazTratamentoMedico)
            .IsRequired()
            .HasColumnType("SMALLINT");
    }
}
