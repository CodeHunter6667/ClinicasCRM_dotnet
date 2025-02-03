using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Repositorios.Base;
using ClinicasCRM.Core.Models.Paciente;

namespace ClinicasCRM.Api.Repositorios.Paciente;

public class MedidasRepositorio : RepositorioBase<Medidas>
{
    public MedidasRepositorio(AppDbContext context) : base(context)
    {
    }
}
