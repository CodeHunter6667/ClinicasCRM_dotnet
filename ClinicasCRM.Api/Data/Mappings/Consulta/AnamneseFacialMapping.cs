﻿using ClinicasCRM.Core.Models.Consulta;
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

        builder.Property(a => a.PrincipaisQueixas)
           .IsRequired()
           .HasColumnType("VARCHAR")
           .HasMaxLength(500);

        builder.Property(x => x.PresencaManchasPigmentaresRelacionadasMelanina)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.PresencasManchasAlteracaoVascular)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.FormacoesSolidas)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.FormacoesComConteudoLiquido)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.LesoesDePele)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.SequelasOuCicatrizes)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.AlteracoesPelosFaciais)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.AlteracoesQueratinizacao)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.ClassificacaoCutanea)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.ClassificacaoEspessura)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.ClassificacaoOleosidade)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.ClassificacaoSensibilidade)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.Observacoes)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(500);

        builder.HasOne(a => a.Cliente)
            .WithMany(x => x.AnamneseFaciais)
            .HasForeignKey("ClienteId");
    }
}
