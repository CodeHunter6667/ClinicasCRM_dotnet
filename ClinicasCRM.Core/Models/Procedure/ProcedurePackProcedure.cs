namespace ClinicasCRM.Core.Models.Procedure
{
    public class ProcedurePackProcedure
    {
        public ProcedurePack ProcedurePack { get; set; } = new();
        public int ProcedurePackId { get; set; }
        public Procedure Procedure { get; set; } = new();
        public int ProcedureId { get; set; }
    }
}
