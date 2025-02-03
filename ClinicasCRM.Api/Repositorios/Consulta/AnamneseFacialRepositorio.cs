using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Repositorios.Base;
using ClinicasCRM.Core.Models.Consulta;

namespace ClinicasCRM.Api.Repositorios.Consulta;

public class AnamneseFacialRepositorio : RepositorioBase<AnamneseFacial>
{
    public AnamneseFacialRepositorio(AppDbContext context) : base(context)
    {
    }
}
