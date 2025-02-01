using ClinicasCRM.Core.Models.Pessoa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Pessoa;

public class PessoaFisicaMapping : IEntityTypeConfiguration<PessoaFisica>
{
    public void Configure(EntityTypeBuilder<PessoaFisica> builder)
    {
        builder.ToTable("PessoasFisicas");

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

        builder.Property(x => x.Telefone)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(20);

        builder.Property(x => x.Email)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

        builder.Property(x => x.TipoCadastro)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.HasOne(x => x.Endereco)
            .WithMany(x => x.PessoasFisicas)
            .HasForeignKey("EnderecoId");

        builder.Property(x => x.NomeCompleto)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(200);

        builder.Property(x => x.DataNascimento)
            .IsRequired(false)
            .HasColumnType("DATE");

        builder.Property(x => x.Cpf)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(11);

        builder.Property(x => x.Genero)
            .IsRequired()
            .HasColumnType("SMALLINT");
    }
}
