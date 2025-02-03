using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Repositorios.Base;
using ClinicasCRM.Core.Models.Paciente;

namespace ClinicasCRM.Api.Repositorios.Paciente;

public class HabitosFemininosRepositorio : RepositorioBase<HabitosFemininos>
{
    public HabitosFemininosRepositorio(AppDbContext context) : base(context)
    {
    }
}
