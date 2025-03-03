using AutoMapper;
using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Servicos.Base;
using ClinicasCRM.Api.Servicos.Paciente.Interfaces;
using ClinicasCRM.Core.Dtos.Paciente;
using ClinicasCRM.Core.Exceptions;
using ClinicasCRM.Core.Models.Paciente;
using Microsoft.EntityFrameworkCore;

namespace ClinicasCRM.Api.Servicos.Paciente;

public class HistoricoPacienteService : BaseService<PatientHistory>, IHistoricoPacienteService
{
    private IMapper _mapper;
    public HistoricoPacienteService(AppDbContext context, IMapper mapper) : base(context)
    {
        _mapper = mapper;
    }

    public async Task<PatientHistoryDto> AtualizarAsync(long id, PatientHistoryDto dto)
    {
        var historico = await ObterAsync(id, dto.UsuarioId);
        if (historico is null)
            throw new NotFoundException("Histórico não encontrado.");
        historico = _mapper.Map(dto, historico);
        historico = await AtualizarAsync(historico);
        return _mapper.Map<PatientHistoryDto>(historico);
    }

    public async Task<PatientHistoryDto> InserirAsync(PatientHistoryDto dto)
    {
        var historico = new PatientHistory();
        _mapper.Map(dto, historico);
        historico = await InserirAsync(historico);
        return _mapper.Map<PatientHistoryDto>(historico);
    }

    public async Task<List<PatientHistoryDto>> ObterPorClienteAsync(long clienteId, string usuarioId)
    {
        var historicos = await _context.PatientHistories
        .AsNoTracking()
        .Where(h =>
        h.ClienteId == clienteId
        && h.UsuarioId == usuarioId).ToListAsync();
        return _mapper.Map<List<PatientHistoryDto>>(historicos);
    }

    public async Task<PatientHistoryDto> ObterPorIdAsync(long id, string usuarioId)
    {
        var historico = await ObterAsync(id, usuarioId);
        if (historico is null)
            throw new NotFoundException("Histórico não encontrado");
        return _mapper.Map<PatientHistoryDto>(historico);
    }

    async Task<List<PatientHistoryDto>> IHistoricoPacienteService.TodosAsync(string usuarioId)
    {
        var historicos = await _context.PatientHistories
        .AsNoTracking()
        .Where(x =>
        x.UsuarioId.Equals(usuarioId, StringComparison.InvariantCultureIgnoreCase)).ToListAsync();
        return _mapper.Map<List<PatientHistoryDto>>(historicos);
    }
}
