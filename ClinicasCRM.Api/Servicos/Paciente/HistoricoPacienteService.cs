using ClinicasCRM.Api.Repositorios.Paciente;
using ClinicasCRM.Api.Servicos.Base;
using ClinicasCRM.Api.Servicos.Paciente.Interfaces;
using ClinicasCRM.Core.Models.Paciente;

namespace ClinicasCRM.Api.Servicos.Paciente;

public class HistoricoPacienteService : ServicoBase<HistoricoPaciente, HistoricoPacienteRepositorio>, IHistoricoPacienteService
{
}
