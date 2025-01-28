using ClinicasCRM.Core.Models.Procedimento;
using Microsoft.EntityFrameworkCore;

namespace ClinicasCRM.Api.Data.Mappings.Procedimento;

public class ProcedimentoMapping : IEntityTypeConfiguration<ClinicasCRM.Core.Models.Procedimento.Procedimento>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ClinicasCRM.Core.Models.Procedimento.Procedimento> builder)
    {
        builder.ToTable("Procedimentos");

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

        builder.Property(x => x.NomeProcedimento)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

        builder.Property(x => x.Duracao)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.EquipamentosUtilizados)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(100);

        builder.Property(x => x.CosumoProdutos)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(100);

        builder.Property(x => x.Preco)
            .IsRequired()
            .HasColumnType("DECIMAL(10,4)");

        builder.Property(x => x.FormaPagamento)
            .IsRequired()
            .HasColumnType("SMALLINT");
    }
}
