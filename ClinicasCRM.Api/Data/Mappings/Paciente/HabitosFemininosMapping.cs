using ClinicasCRM.Core.Models.Paciente;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Paciente;

public class HabitosFemininosMapping : IEntityTypeConfiguration<HabitosFemininos>
{
    public void Configure(EntityTypeBuilder<HabitosFemininos> builder)
    {
        builder.ToTable("HabitosFemininos");

        builder.Property(x => x.CicloMenstrualRegular)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.UsoAnticoncepcionalRegular)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.Gestante)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.Lactante)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.TemFilhos)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.QuantosFilhos)
            .IsRequired()
            .HasColumnType("SMALLINT");
    }
}
