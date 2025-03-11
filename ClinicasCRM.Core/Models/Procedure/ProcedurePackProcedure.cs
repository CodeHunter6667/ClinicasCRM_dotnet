namespace ClinicasCRM.Core.Models.Procedure
{
    public class ProcedurePackProcedure
    {
        public ProcedurePack ProcedurePack { get; set; } = new();
        public long ProcedurePackId { get; set; }
        public Procedure Procedure { get; set; } = new();
        public long ProcedureId { get; set; }
    }
}
