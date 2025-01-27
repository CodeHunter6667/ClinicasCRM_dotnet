using Microsoft.EntityFrameworkCore;

namespace ClinicasCRM.Api.Data.Mappings.Agendamento;

public class AgendamentoMapping : IEntityTypeConfiguration<ClinicasCRM.Core.Models.Agendamento.Agendamento>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ClinicasCRM.Core.Models.Agendamento.Agendamento> builder)
    {
        builder.ToTable("Agendamentos");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.SalaAtendimento)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

        builder.Property(x => x.DiaAtendimento)
            .IsRequired()
            .HasColumnType("TIMESTAMP");

        builder.Property(x => x.Profissional)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

        builder.Property(x => x.Duracao)
            .IsRequired()
            .HasColumnType("INTEGER");

        builder.Property(x => x.StatusAtendimento)
            .IsRequired()
            .HasColumnType("SMALLINT");
    }
}
