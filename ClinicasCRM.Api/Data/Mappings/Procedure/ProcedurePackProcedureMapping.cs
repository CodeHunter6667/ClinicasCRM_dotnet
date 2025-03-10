using ClinicasCRM.Core.Models.Procedure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicasCRM.Api.Data.Mappings.Procedure;

public class ProcedurePackProcedureMapping : IEntityTypeConfiguration<ProcedurePackProcedure>
{
    public void Configure(EntityTypeBuilder<ProcedurePackProcedure> builder)
    {
        builder.ToTable("ProcedurePackProcedure");

        builder.HasKey(x => new { x.ProcedureId, x.ProcedurePackId });

        builder.HasOne(x => x.ProcedurePack)
            .WithMany(x => x.ProcedurePackProcedures)
            .HasForeignKey(x => x.ProcedurePackId);

        builder.HasOne(x => x.Procedure)
            .WithMany(x => x.ProcedurePackProcedures)
            .HasForeignKey(x => x.ProcedureId);
    }
}
