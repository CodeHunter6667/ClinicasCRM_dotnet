using ClinicasCRM.Core.Models.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Person;

public class ProfessionalMapping : IEntityTypeConfiguration<Professional>
{
    public void Configure(EntityTypeBuilder<Professional> builder)
    {
        builder.ToTable("Professionals");

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

        builder.Property(x => x.Phone)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(20);

        builder.Property(x => x.Email)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

        builder.Property(x => x.RecordType)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(200);

        builder.Property(x => x.Cpf)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(11);

        builder.Property(x => x.ProfessionalNumber)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(20);

        builder.Property(x => x.ProfessionalCouncil)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(20);

        builder.Property(x => x.ProfessionalCouncilState)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(10);

        builder.Property(x => x.Type)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.Birthday)
            .IsRequired(false)
            .HasColumnType("DATE");
    }
}
