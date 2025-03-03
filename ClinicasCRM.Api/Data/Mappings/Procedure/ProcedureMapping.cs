using Microsoft.EntityFrameworkCore;

namespace ClinicasCRM.Api.Data.Mappings.Procedure;

public class ProcedureMapping : IEntityTypeConfiguration<ClinicasCRM.Core.Models.Procedure.Procedure>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ClinicasCRM.Core.Models.Procedure.Procedure> builder)
    {
        builder.ToTable("Procedures");

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

        builder.Property(x => x.ProcedureName)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

        builder.Property(x => x.DurationInMinutes)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.EquipmentUsed)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(100);

        builder.Property(x => x.ConsumedProducts)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(100);

        builder.Property(x => x.Price)
            .IsRequired()
            .HasColumnType("DECIMAL(10,4)");

        builder.Property(x => x.PaymentMethod)
            .IsRequired()
            .HasColumnType("SMALLINT");
    }
}
