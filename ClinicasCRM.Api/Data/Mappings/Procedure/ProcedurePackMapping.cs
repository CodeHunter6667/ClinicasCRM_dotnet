using ClinicasCRM.Core.Models.Procedure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Procedure;

public class ProcedurePackMapping : IEntityTypeConfiguration<ProcedurePack>
{
    public void Configure(EntityTypeBuilder<ProcedurePack> builder)
    {
        builder.ToTable("ProcedurePacks");

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

        builder.Property(x => x.PackName)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(100);

        builder.Property(x => x.Description)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(800);

        builder.Property(x => x.Price)
            .IsRequired()
            .HasColumnType("DECIMAL(12,4)");

        builder.Property(x => x.Active)
            .IsRequired()
            .HasColumnType("SMALLINT");
    }
}
