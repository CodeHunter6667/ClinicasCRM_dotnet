using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Repositorios.Base;
using ClinicasCRM.Core.Models.Consulta;

namespace ClinicasCRM.Api.Repositorios.Consulta;

public class AnamneseCorporalRepositorio : RepositorioBase<AnamneseCorporal>
{
    public AnamneseCorporalRepositorio(AppDbContext context) : base(context)
    {
    }
}
