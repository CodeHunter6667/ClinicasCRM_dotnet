using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Servicos.Base;
using ClinicasCRM.Api.Servicos.Paciente.Interfaces;
using ClinicasCRM.Core.Models.Paciente;

namespace ClinicasCRM.Api.Servicos.Paciente;

public class MedidasService : ServicoBase<Medidas>, IMedidasService
{
    public MedidasService(AppDbContext context) : base(context)
    {
        
    }
}
