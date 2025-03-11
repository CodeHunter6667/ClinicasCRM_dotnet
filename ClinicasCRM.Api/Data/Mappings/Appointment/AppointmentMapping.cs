using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Appointment;

public class AppointmentMapping : IEntityTypeConfiguration<ClinicasCRM.Core.Models.Appointment.Appointment>
{
    public void Configure(EntityTypeBuilder<ClinicasCRM.Core.Models.Appointment.Appointment> builder)
    {
        builder.ToTable("Appointments");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
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

        builder.Property(x => x.ProcedureRoom)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

        builder.Property(x => x.AppoitmentDate)
            .IsRequired()
            .HasColumnType("DATE");

        builder.Property(x => x.AppoitmentTime)
            .IsRequired()
            .HasColumnType("TIME WITHOUT TIME ZONE");

        builder.Property(x => x.AppoitmentStatus)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.HasOne(x => x.Client)
            .WithMany(x => x.Appointments)
            .HasForeignKey("ClientId");
        
        builder.HasOne(x => x.Professional)
            .WithMany(x => x.Appointments)
            .HasForeignKey("ProfessionalId");

        builder.HasOne(x => x.Procedure)
            .WithMany(x => x.Appointments)
            .HasForeignKey("ProcedureId");
    }
}
