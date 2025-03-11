using ClinicasCRM.Core.Models.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Person;

public class LegalEntityMapping : IEntityTypeConfiguration<LegalEntity>
{
    public void Configure(EntityTypeBuilder<LegalEntity> builder)
    {
        builder.ToTable("LegalEntities");

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

        builder.HasOne(x => x.Address)
            .WithMany(x => x.LegalEntities)
            .HasForeignKey("EnderecoId");

        builder.Property(x => x.CompanyName)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(250);

        builder.Property(x => x.TradeName)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(250);

        builder.Property(x => x.Cnpj)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(20);

        builder.Property(x => x.StateRegistration)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(20);

        builder.Property(x => x.CityRegistration)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(20);
    }
}
