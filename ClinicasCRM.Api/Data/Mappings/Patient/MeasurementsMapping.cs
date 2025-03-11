using ClinicasCRM.Core.Models.Patient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Patient;

public class MeasurementsMapping : IEntityTypeConfiguration<Measurements>
{
    public void Configure(EntityTypeBuilder<Measurements> builder)
    {
        builder.ToTable("Measurements");

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

        builder.Property(x => x.Weight)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.Height)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.Bust)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.LeftArm)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.RightArm)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.UpperAbdomen)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.Hip)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.LeftThigh)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.RightThigh)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.LeftCalf)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.RightThigh)
            .IsRequired()
            .HasColumnType("REAL");

        builder.Property(x => x.MeasurementDate)
            .IsRequired()
            .HasColumnType("TIMESTAMP");

        builder.HasOne(x => x.Client)
            .WithMany(x => x.Measurements)
            .HasForeignKey("ClientId");
    }
}
