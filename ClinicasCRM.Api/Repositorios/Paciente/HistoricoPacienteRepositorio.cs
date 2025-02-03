using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Repositorios.Base;
using ClinicasCRM.Core.Models.Paciente;

namespace ClinicasCRM.Api.Repositorios.Paciente;

public class HistoricoPacienteRepositorio : RepositorioBase<HistoricoPaciente>
{
    public HistoricoPacienteRepositorio(AppDbContext context) : base(context)
    {
    }
}
