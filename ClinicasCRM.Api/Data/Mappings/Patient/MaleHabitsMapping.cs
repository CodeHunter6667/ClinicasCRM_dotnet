using ClinicasCRM.Core.Models.Patient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Patient;

public class MaleHabitsMapping : IEntityTypeConfiguration<MaleHabits>
{
    public void Configure(EntityTypeBuilder<MaleHabits> builder)
    {
        builder.ToTable("MaleHabits");

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

        builder.Property(x => x.BalencedDiet)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.RegularBowels)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.RegularSleep)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.PracticesPhysicalActivities)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.PhysicalActivityDaysPerWeek)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.Smoker)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.ConsumesAlcoholicBeverage)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.UseAcidOnSkin)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.AlcoholConsumptionFrequency)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.AcidsUsed)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(150);

        builder.Property(x => x.UsesDailySunscreen)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.HasOne(x => x.Client)
            .WithMany(x => x.MaleHabits)
            .HasForeignKey("ClienteId");
    }
}
