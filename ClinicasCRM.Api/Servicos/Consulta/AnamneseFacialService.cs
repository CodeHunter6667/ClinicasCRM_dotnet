using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Servicos.Base;
using ClinicasCRM.Api.Servicos.Consulta.Interfaces;
using ClinicasCRM.Core.Models.Consulta;

namespace ClinicasCRM.Api.Servicos.Consulta;

public class AnamneseFacialService : ServicoBase<AnamneseFacial>, IAnamneseFacialService
{
    public AnamneseFacialService(AppDbContext context) : base(context)
    {
        
    }
}
