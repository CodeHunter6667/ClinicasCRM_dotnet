using ClinicasCRM.Core.Models.Patient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Patient;

public class PatientHistoryMapping : IEntityTypeConfiguration<PatientHistory>
{
    public void Configure(EntityTypeBuilder<PatientHistory> builder)
    {
        builder.ToTable("PatientHistories");

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

        builder.Property(x => x.PreviousTreatments)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(300);

        builder.Property(x => x.Allergies)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(255);

        builder.Property(x => x.OncologicalTreatments)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(255);

        builder.Property(x => x.Hypertension)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.HeartProblem)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.Pacemaker)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.MetalProstheses)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.DentalProstheses)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.Epilepsy)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.UnderMedicalTreatment)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.HasOne(x => x.Client)
            .WithMany(x => x.PatientHistories)
            .HasForeignKey("ClientId");
    }
}
