using ClinicasCRM.Core.Models.Consulta;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Consulta;

public class AnamneseCorporalMapping : IEntityTypeConfiguration<AnamneseCorporal>
{
    public void Configure(EntityTypeBuilder<AnamneseCorporal> builder)
    {
        builder.ToTable("AnamnesesCorporais");

        builder.HasOne(x => x.AvaliacaoCorporal)
            .WithMany(x => x.AnamnesesCorporal)
            .HasForeignKey("AvaliacaoCorporalId");
    }
}
