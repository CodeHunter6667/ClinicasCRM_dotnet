using ClinicasCRM.Core.Models.Paciente;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Paciente;

public class HabitosMasculinosMapping : IEntityTypeConfiguration<HabitosMasculinos>
{
    public void Configure(EntityTypeBuilder<HabitosMasculinos> builder)
    {
        builder.ToTable("HabitosMasculinos");

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

        builder.Property(x => x.AlimentacaoBalanceada)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.IntestinoRegular)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.SonoRegular)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.PraticaAtividadesFisicas)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.DiasAtividadeFisica)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.Fumante)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.ConsomeBebidaAlcoolica)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.UsoAcidosNaPele)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.ConsumoAlcool)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.AcidosUsados)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(150);

        builder.Property(x => x.UsaProtetorSolarDiario)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.HasOne(x => x.Cliente)
            .WithMany(x => x.HabitosMasculinos)
            .HasForeignKey("ClienteId");
    }
}
