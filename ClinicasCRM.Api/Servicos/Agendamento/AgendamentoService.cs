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

    public async Task<AgendamentoDto> AtualizarAsync(AgendamentoDto agendamentoDto)
    {
        var agendamento = await ObterAsync(agendamentoDto.Id);
        if (agendamento is null)
            throw new NotFoundException("Agendamento não encontrado");
        agendamento = mapper.Map(agendamentoDto, agendamento);
        agendamento = await AtualizarAsync(agendamento);
        return mapper.Map<AgendamentoDto>(agendamento);
    }

    public async Task<AgendamentoDto> InserirAsync(AgendamentoDto agendamentoDto)
    {
        var agendamentos = await TodosAsync();
        if (agendamentos.Any(a =>
        a.HoraAtendimento.Hours == agendamentoDto.HoraAtendimento.Hours
        && a.HoraAtendimento.Minutes == agendamentoDto.HoraAtendimento.Minutes))
            throw new BadRequestException("Já existe um agendamento para esse dia");

        var agendamento = mapper.Map<ClinicasCRM.Core.Models.Agendamento.Agendamento>(agendamentoDto);
        agendamento = await InserirAsync(agendamento);
        return mapper.Map<AgendamentoDto>(agendamento);
    }

    public async Task<AgendamentoDto> ObterPorIdAsync(long id)
    {
        var agendamento = await ObterAsync(id);
        return mapper.Map<AgendamentoDto>(agendamento);
    }

    public async Task<List<AgendamentoDto>> TodosPorClienteAsync(long clienteId, ParametrosPaginacao parametrosPaginacao)
    {
        var agendamentos = _context.Agendamentos
                                        .AsNoTracking()
                                        .Where(a => a.ClienteId == clienteId)
                                        .Skip((parametrosPaginacao.NumeroPagina - 1) * parametrosPaginacao.TamanhoPagina)
                                        .Take(parametrosPaginacao.TamanhoPagina)
                                        .OrderBy(a => a.DataAtendimento);
        var listaAgendamentos = await agendamentos.ToListAsync();
        return mapper.Map<List<AgendamentoDto>>(listaAgendamentos);
    }

    public async Task<List<AgendamentoDto>> TodosPorDataAsync(DateTime data, ParametrosPaginacao parametrosPaginacao)
    {
        var agendamentos = _context
            .Agendamentos
            .AsNoTracking()
            .Where(a =>
            a.DataAtendimento.Date == data.Date
            && a.StatusAtendimento == EStatusAtendimento.Finalizado)
            .Skip((parametrosPaginacao.NumeroPagina - 1) * parametrosPaginacao.TamanhoPagina)
            .Take(parametrosPaginacao.TamanhoPagina);
        var listaAgendamentos = await agendamentos.ToListAsync();
        return mapper.Map<List<AgendamentoDto>>(listaAgendamentos);
    }

    public async Task<List<AgendamentoDto>> TodosPorDataAsync(DateTime dataInicial, DateTime dataFinal)
    {
        var agendamentos = _context
            .Agendamentos
            .AsNoTracking()
            .Where(a =>
            a.DataAtendimento.Date >= dataInicial.Date
            && a.DataAtendimento.Date <= dataFinal.Date);
        var listaAgendamentos = await agendamentos.ToListAsync();
        return mapper.Map<List<AgendamentoDto>>(listaAgendamentos);
    }

    public async Task<List<AgendamentoDto>> TodosAsync(ParametrosPaginacao parametrosPaginacao)
    {
        var agendamentos = await TodosAsync();
        return mapper.Map<List<AgendamentoDto>>(agendamentos
                                                .Skip((parametrosPaginacao.NumeroPagina - 1) * parametrosPaginacao.TamanhoPagina)
                                                .Take(parametrosPaginacao.TamanhoPagina)
                                                .ToList());
    }
}
