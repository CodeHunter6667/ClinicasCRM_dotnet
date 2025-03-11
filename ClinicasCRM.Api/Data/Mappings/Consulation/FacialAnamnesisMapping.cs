using ClinicasCRM.Core.Models.Consulation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Consulation;

public class FacialAnamnesisMapping : IEntityTypeConfiguration<FacialAnamnesis>
{
    public void Configure(EntityTypeBuilder<FacialAnamnesis> builder)
    {
        builder.ToTable("FacialAnamnesis");
        builder.HasKey(a => a.Id);

        builder.Property(a => a.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        builder.Property(x => x.CreatedBy)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

        builder.Property(x => x.UpdatedBy)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);
        
        builder.Property(x => x.IsSaved)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.CreatedAt)
            .IsRequired()
            .HasColumnType("TIMESTAMP");

        builder.Property(x => x.UpdatedAt)
            .HasColumnType("TIMESTAMP");

        builder.Property(x => x.UserId)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

        builder.Property(a => a.MainComplaints)
           .IsRequired()
           .HasColumnType("VARCHAR")
           .HasMaxLength(500);

        builder.Property(x => x.MelaninRelatedPigmentSpotsPresent)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.VascularAlterationSpotsPresent)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.SolidFormationsPresent)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.LiquidContentFormationsPresent)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.SkinLesionsPresent)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.SequelaeOrScarsPresent)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.FacialHairAlterationsPresent)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.KeratinizationAlterationsPresent)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.SkinClassification)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.SkinThicknessClassification)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.OilinessClassification)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.SensitivityClassification)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.Notes)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(500);

        builder.HasOne(a => a.Client)
            .WithMany(x => x.FacialAnamneses)
            .HasForeignKey("ClienteId");
    }
}
