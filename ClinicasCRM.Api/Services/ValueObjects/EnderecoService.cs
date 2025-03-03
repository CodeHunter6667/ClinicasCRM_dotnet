using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Servicos.Base;
using ClinicasCRM.Api.Servicos.ValueObjects.Interfaces;
using ClinicasCRM.Core.ValueObjects;

namespace ClinicasCRM.Api.Servicos.ValueObjects;

public class EnderecoService : BaseService<Endereco>, IEnderecoService
{
    public EnderecoService(AppDbContext context) : base(context)
    {
        
    }
}
