using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Repositorios.Base;
using ClinicasCRM.Core.Models.Paciente;

namespace ClinicasCRM.Api.Repositorios.Paciente;

public class HabitosMasculinosRepositorio : RepositorioBase<HabitosMasculinos>
{
    public HabitosMasculinosRepositorio(AppDbContext context) : base(context)
    {
    }
}
