using AutoMapper;
using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Servicos.Base;
using ClinicasCRM.Api.Servicos.Paciente.Interfaces;
using ClinicasCRM.Core.Dtos.Paciente;
using ClinicasCRM.Core.Exceptions;
using ClinicasCRM.Core.Models.Paciente;
using Microsoft.EntityFrameworkCore;

namespace ClinicasCRM.Api.Servicos.Paciente;

public class HistoricoPacienteService : ServicoBase<HistoricoPaciente>, IHistoricoPacienteService
{
    private IMapper _mapper;
    public HistoricoPacienteService(AppDbContext context, IMapper mapper) : base(context)
    {
        _mapper = mapper;
    }

    public async Task<HistoricoPacienteDto> AtualizarAsync(long id, HistoricoPacienteDto dto)
    {
        var historico = await ObterAsync(id, dto.UsuarioId);
        if (historico is null)
            throw new NotFoundException("Histórico não encontrado.");
        historico = _mapper.Map(dto, historico);
        historico = await AtualizarAsync(historico);
        return _mapper.Map<HistoricoPacienteDto>(historico);
    }

    public async Task<HistoricoPacienteDto> InserirAsync(HistoricoPacienteDto dto)
    {
        var historico = new HistoricoPaciente();
        _mapper.Map(dto, historico);
        historico = await InserirAsync(historico);
        return _mapper.Map<HistoricoPacienteDto>(historico);
    }

    public async Task<List<HistoricoPacienteDto>> ObterPorClienteAsync(long clienteId, string usuarioId)
    {
        var historicos = await _context.HistoricoPacientes
        .AsNoTracking()
        .Where(h =>
        h.ClienteId == clienteId
        && h.UsuarioId == usuarioId).ToListAsync();
        return _mapper.Map<List<HistoricoPacienteDto>>(historicos);
    }

    public async Task<HistoricoPacienteDto> ObterPorIdAsync(long id, string usuarioId)
    {
        var historico = await ObterAsync(id, usuarioId);
        if (historico is null)
            throw new NotFoundException("Histórico não encontrado");
        return _mapper.Map<HistoricoPacienteDto>(historico);
    }

    async Task<List<HistoricoPacienteDto>> IHistoricoPacienteService.TodosAsync(string usuarioId)
    {
        var historicos = await _context.HistoricoPacientes
        .AsNoTracking()
        .Where(x =>
        x.UsuarioId.Equals(usuarioId, StringComparison.InvariantCultureIgnoreCase)).ToListAsync();
        return _mapper.Map<List<HistoricoPacienteDto>>(historicos);
    }
}
