using ClinicasCRM.Core.Models.Consulta;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Consulta;

public class AnamneseFacialMapping : IEntityTypeConfiguration<AnamneseFacial>
{
    public void Configure(EntityTypeBuilder<AnamneseFacial> builder)
    {
        builder.ToTable("AnamnesesFaciais");
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

        builder.HasOne(x => x.AvaliacaoFacial)
            .WithMany(x => x.AnamnesesFaciais)
            .HasForeignKey("AvaliacaoFacialId");

        builder.HasOne(a => a.Cliente)
            .WithMany(x => x.AnamneseFaciais)
            .HasForeignKey("ClienteId");
    }
}
