using ClinicasCRM.Core.Models.Avaliacao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Avaliacao;

public class AvaliacaoCorporalMapping : IEntityTypeConfiguration<AvaliacaoCorporal>
{
    public void Configure(EntityTypeBuilder<AvaliacaoCorporal> builder)
    {
        builder.ToTable("AvaliacoesCorporais");

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

        builder.Property(x => x.PrincipaisQueixas)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(500);

        builder.Property(x => x.AnotacoesTratamentoEscolhido)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(500);

        builder.Property(x => x.DataAvaliacao)
            .IsRequired()
            .HasColumnType("TIMESTAMP");

        builder.Property(x => x.Observacoes)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(500);

        builder.HasOne(x => x.Cliente)
            .WithMany(x => x.AvaliaçõesCorporais)
            .HasForeignKey("ClienteId");

        builder.HasOne(x => x.Medidas)
            .WithMany(x => x.AvaliacoesCorporais)
            .HasForeignKey("MedidasId");
    }
}
