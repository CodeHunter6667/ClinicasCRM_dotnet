using ClinicasCRM.Core.Models.Pessoa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Pessoa;

public class PessoaJuridicaMapping : IEntityTypeConfiguration<PessoaJuridica>
{
    public void Configure(EntityTypeBuilder<PessoaJuridica> builder)
    {
        builder.ToTable("PessoasJuridicas");

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
            .WithMany(x => x.PessoaJuridicas)
            .HasForeignKey("EnderecoId");

        builder.Property(x => x.RazaoSocial)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(250);

        builder.Property(x => x.NomeFantasia)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(250);

        builder.Property(x => x.Cnpj)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(20);

        builder.Property(x => x.InscricaoEstadual)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(20);

        builder.Property(x => x.InscricaoMunicipal)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(20);
    }
}
