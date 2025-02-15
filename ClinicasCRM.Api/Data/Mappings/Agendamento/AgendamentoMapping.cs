using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Agendamento;

public class AgendamentoMapping : IEntityTypeConfiguration<ClinicasCRM.Core.Models.Agendamento.Agendamento>
{
    public void Configure(EntityTypeBuilder<ClinicasCRM.Core.Models.Agendamento.Agendamento> builder)
    {
        builder.ToTable("Agendamentos");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
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

        builder.Property(x => x.SalaAtendimento)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

        builder.Property(x => x.DataAtendimento)
            .IsRequired()
            .HasColumnType("DATE");

        builder.Property(x => x.Profissional)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

        builder.Property(x => x.HoraAtendimento)
            .IsRequired()
            .HasColumnType("TIME WITHOUT TIME ZONE");

        builder.Property(x => x.StatusAtendimento)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.HasOne(x => x.Cliente)
            .WithMany(x => x.Agendamentos)
            .HasForeignKey("ClienteId");

        builder.HasOne(x => x.Procedimento)
            .WithMany(x => x.Agendamentos)
            .HasForeignKey("ProcedimentoId");
    }
}
