using ClinicasCRM.Api.Repositorios.Procedimento;
using ClinicasCRM.Api.Servicos.Base;
using ClinicasCRM.Api.Servicos.Base.Interfaces;

namespace ClinicasCRM.Api.Servicos.Procedimento;

public class ProcedimentoService : ServicoBase<ClinicasCRM.Core.Models.Procedimento.Procedimento, ProcedimentoRepositorio>, IServicoBase
{
}
