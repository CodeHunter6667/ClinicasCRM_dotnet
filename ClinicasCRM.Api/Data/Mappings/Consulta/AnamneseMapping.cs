using ClinicasCRM.Core.Models.Consulta;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Consulta;

public class AnamneseMapping : IEntityTypeConfiguration<Anamnese>
{
    public void Configure(EntityTypeBuilder<Anamnese> builder)
    {
        builder.ToTable("Anamneses");

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

        builder.HasOne(a => a.Cliente)
            .WithMany(x => x.Anamneses)
            .HasForeignKey("ClienteId");

        builder.HasOne(a => a.Historico)
            .WithMany(x => x.Anamneses)
            .HasForeignKey("HistoricoId");

        builder.HasOne(a => a.Habitos)
            .WithMany(x => x.Anamneses)
            .HasForeignKey("HabitosId");

        builder.HasDiscriminator<string>("TipoAnamnese")
            .HasValue<Anamnese>("Anamnese")
            .HasValue<AnamneseCorporal>("AnamneseCorporal")
            .HasValue<AnamneseFacial>("AnamneseFacial");
    }
}
