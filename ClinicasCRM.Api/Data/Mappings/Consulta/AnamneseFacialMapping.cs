using ClinicasCRM.Core.Models.Consulta;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Consulta;

public class AnamneseFacialMapping : IEntityTypeConfiguration<AnamneseFacial>
{
    public void Configure(EntityTypeBuilder<AnamneseFacial> builder)
    {
        builder.ToTable("AnamnesesFaciais");

        builder.HasOne(x => x.AvaliacaoFacial)
            .WithMany(x => x.AnamnesesFaciais)
            .HasForeignKey("AvaliacaoFacialId");
    }
}
