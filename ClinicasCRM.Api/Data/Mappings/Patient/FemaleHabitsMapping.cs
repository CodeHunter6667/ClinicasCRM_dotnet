using ClinicasCRM.Core.Models.Patient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Patient;

public class FemaleHabitsMapping : IEntityTypeConfiguration<FemaleHabits>
{
    public void Configure(EntityTypeBuilder<FemaleHabits> builder)
    {
        builder.ToTable("FemaleHabits");

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

        builder.Property(x => x.RegularMenstrualCycle)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.RegularContraceptiveUse)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.Pregnant)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.Breastfeeding)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.HasChildren)
            .IsRequired()
            .HasColumnType("SMALLINT");

        builder.Property(x => x.NumberOfChildren)
            .IsRequired(false)
            .HasColumnType("SMALLINT");

        builder.HasOne(x => x.Client)
            .WithMany(x => x.FemaleHabits)
            .HasForeignKey("ClientId");
    }
}
