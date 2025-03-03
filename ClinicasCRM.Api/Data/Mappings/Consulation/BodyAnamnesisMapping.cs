using ClinicasCRM.Core.Models.Consulation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Consulation;

public class BodyAnamnesisMapping : IEntityTypeConfiguration<BodyAnamnesis>
{
    public void Configure(EntityTypeBuilder<BodyAnamnesis> builder)
    {
        builder.ToTable("BodyAnamnesis");

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
            .HasColumnType("BIGINT");

        builder.Property(x => x.MainComplaints)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(500);

        builder.Property(x => x.ChosenTreatmentNotes)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(500);

        builder.Property(x => x.AssessmentDate)
            .IsRequired()
            .HasColumnType("TIMESTAMP");

        builder.Property(x => x.Notes)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(500);

        builder.HasOne(a => a.Client)
            .WithMany(x => x.BodyAnamneses)
            .HasForeignKey("ClientId");
        
        builder.HasOne(x => x.Measurement)
            .WithMany(x => x.BodyAnamneses)
            .HasForeignKey("MeasurementsId");
    }
}
