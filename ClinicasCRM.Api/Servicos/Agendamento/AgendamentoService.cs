using AutoMapper;
using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Servicos.Agendamento.Interfaces;
using ClinicasCRM.Api.Servicos.Base;
using ClinicasCRM.Core.Common;
using ClinicasCRM.Core.Dtos.Agendamento;
using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace ClinicasCRM.Api.Servicos.Agendamento;

public class AgendamentoService : ServicoBase<ClinicasCRM.Core.Models.Agendamento.Agendamento>, IAgendamentoService
{
    private readonly IMapper mapper;

    public AgendamentoService(IMapper _mapper, AppDbContext context) : base(context)
    {
        mapper = _mapper;
    }

    public async Task<AgendamentoDto> AtualizarAsync(long id, AgendamentoDto agendamentoDto)
    {
        var agendamento = await ObterAsync(id, agendamentoDto.UsuarioId);
        if (agendamento is null)
            throw new NotFoundException("Agendamento não encontrado");
        agendamento = mapper.Map(agendamentoDto, agendamento);
        agendamento = await AtualizarAsync(agendamento);
        return mapper.Map<AgendamentoDto>(agendamento);
    }

    public async Task<AgendamentoDto> InserirAsync(AgendamentoDto agendamentoDto)
    {
        var agendamentos = await TodosAsync(agendamentoDto.UsuarioId);
        if (agendamentos.Any(a =>
        a.HoraAtendimento.Hours == agendamentoDto.HoraAtendimento.Hours
        && a.HoraAtendimento.Minutes == agendamentoDto.HoraAtendimento.Minutes))
            throw new BadRequestException("Já existe um agendamento para esse dia");

        var agendamento = mapper.Map<ClinicasCRM.Core.Models.Agendamento.Agendamento>(agendamentoDto);
        agendamento = await InserirAsync(agendamento);
        return mapper.Map<AgendamentoDto>(agendamento);
    }

    public async Task<AgendamentoDto> ObterPorIdAsync(long id, string usuarioId)
    {
        var agendamento = await ObterAsync(id, usuarioId);
        return mapper.Map<AgendamentoDto>(agendamento);
    }

    public async Task<List<AgendamentoDto>> TodosPorClienteAsync(long clienteId,string usuarioId, ParametrosPaginacao parametrosPaginacao)
    {
        var agendamentos = _context.Agendamentos
                                        .AsNoTracking()
                                        .Where(a => a.ClienteId == clienteId && a.UsuarioId.Equals(usuarioId, StringComparison.InvariantCultureIgnoreCase))
                                        .Skip((parametrosPaginacao.NumeroPagina - 1) * parametrosPaginacao.TamanhoPagina)
                                        .Take(parametrosPaginacao.TamanhoPagina)
                                        .OrderBy(a => a.DataAtendimento);
        var listaAgendamentos = await agendamentos.ToListAsync();
        return mapper.Map<List<AgendamentoDto>>(listaAgendamentos);
    }

    public async Task<List<AgendamentoDto>> TodosPorDataAsync(DateTime data, string usuarioId, ParametrosPaginacao parametrosPaginacao)
    {
        var agendamentos = _context
            .Agendamentos
            .AsNoTracking()
            .Where(a =>
            a.DataAtendimento.Date == data.Date
            && a.UsuarioId.Equals(usuarioId, StringComparison.InvariantCultureIgnoreCase)
            && a.StatusAtendimento == EStatusAtendimento.Finalizado)
            .Skip((parametrosPaginacao.NumeroPagina - 1) * parametrosPaginacao.TamanhoPagina)
            .Take(parametrosPaginacao.TamanhoPagina);
        var listaAgendamentos = await agendamentos.ToListAsync();
        return mapper.Map<List<AgendamentoDto>>(listaAgendamentos);
    }

    public async Task<List<AgendamentoDto>> TodosPorDataAsync(DateTime dataInicial, DateTime dataFinal, string usuarioId)
    {
        var agendamentos = _context
            .Agendamentos
            .AsNoTracking()
            .Where(a =>
            a.DataAtendimento.Date >= dataInicial.Date
            && a.DataAtendimento.Date <= dataFinal.Date
            && a.UsuarioId.Equals(usuarioId, StringComparison.InvariantCultureIgnoreCase));
        var listaAgendamentos = await agendamentos.ToListAsync();
        return mapper.Map<List<AgendamentoDto>>(listaAgendamentos);
    }

    public async Task<List<AgendamentoDto>> TodosAsync(ParametrosPaginacao parametrosPaginacao, string usuarioId)
    {
        var agendamentos = await TodosAsync(usuarioId);
        return mapper.Map<List<AgendamentoDto>>(agendamentos
                                                .Skip((parametrosPaginacao.NumeroPagina - 1) * parametrosPaginacao.TamanhoPagina)
                                                .Take(parametrosPaginacao.TamanhoPagina)
                                                .ToList());
    }
}
