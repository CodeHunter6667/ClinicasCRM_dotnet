using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Repositorios.Base;
using ClinicasCRM.Core.ValueObjects;

namespace ClinicasCRM.Api.Repositorios.ValueObjects;

public class EnderecoRepositorio : RepositorioBase<Endereco>
{
    public EnderecoRepositorio(AppDbContext context) : base(context)
    {
    }
}
