using ClinicasCRM.Core.Models.Paciente;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Paciente;

public class MedidasMapping : IEntityTypeConfiguration<Medidas>
{
    public void Configure(EntityTypeBuilder<Medidas> builder)
    {
        builder.ToTable("Medidas");

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

        builder.Property(x => x.Peso)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.Altura)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.Busto)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.BracoEsquerdo)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.BracoDireito)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.AbdomenSuperior)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.Quadril)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.CoxaEsquerda)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.CoxaDireita)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.PanturrilhaEsquerda)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.PanturrilhaDireita)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.DataMedicao)
            .IsRequired()
            .HasColumnType("TIMESTAMP");
    }
}
