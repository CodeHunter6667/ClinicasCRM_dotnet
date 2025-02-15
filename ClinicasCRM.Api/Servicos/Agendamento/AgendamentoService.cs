using AutoMapper;
using ClinicasCRM.Api.Repositorios.Agendamento;
using ClinicasCRM.Api.Servicos.Agendamento.Interfaces;
using ClinicasCRM.Api.Servicos.Base;
using ClinicasCRM.Core.Common;
using ClinicasCRM.Core.Dtos.Agendamento;
using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.Exceptions;

namespace ClinicasCRM.Api.Servicos.Agendamento;

public class AgendamentoService(IMapper _mapper) : ServicoBase<ClinicasCRM.Core.Models.Agendamento.Agendamento, AgendamentoRepositorio>, IAgendamentoService
{
    public async Task<AgendamentoDto> AtualizarAsync(AgendamentoDto agendamentoDto)
    {
        var agendamento = await ObterAsync(agendamentoDto.Id);
        if (agendamento is null)
            throw new NotFoundException("Agendamento não encontrado");
        agendamento = _mapper.Map(agendamentoDto, agendamento);
        agendamento = await AtualizarAsync(agendamento);
        return _mapper.Map<AgendamentoDto>(agendamento);
    }

    public async Task<AgendamentoDto> InserirAsync(AgendamentoDto agendamentoDto)
    {
        var agendamentos = await TodosAsync();
        if (agendamentos.Any(a =>
        a.HoraAtendimento.Hours == agendamentoDto.HoraAtendimento.Hours
        && a.HoraAtendimento.Minutes == agendamentoDto.HoraAtendimento.Minutes))
            throw new BadRequestException("Já existe um agendamento para esse dia");

        var agendamento = _mapper.Map<ClinicasCRM.Core.Models.Agendamento.Agendamento>(agendamentoDto);
        agendamento = await InserirAsync(agendamento);
        return _mapper.Map<AgendamentoDto>(agendamento);
    }

    public async Task<AgendamentoDto> ObterPorIdAsync(long id)
    {
        var agendamento = await ObterAsync(id);
        return _mapper.Map<AgendamentoDto>(agendamento);
    }

    public async Task<List<AgendamentoDto>> TodosPorClienteAsync(long clienteId, ParametrosPaginacao parametrosPaginacao)
    {
        var agendamentos = await TodosAsync();
        agendamentos = agendamentos
                                .Where(a => a.ClienteId == clienteId)
                                .Skip((parametrosPaginacao.NumeroPagina - 1) * parametrosPaginacao.TamanhoPagina)
                                .Take(parametrosPaginacao.TamanhoPagina)
                                .ToList();
        return _mapper.Map<List<AgendamentoDto>>(agendamentos);
    }

    public async Task<List<AgendamentoDto>> TodosPorDataAsync(DateTime data, ParametrosPaginacao parametrosPaginacao)
    {
        var agendamentos = await TodosAsync();
        agendamentos = agendamentos
                                .Where(a =>
                                a.DataAtendimento.Date == data.Date
                                && a.StatusAtendimento == EStatusAtendimento.Finalizado)
                                .Skip((parametrosPaginacao.NumeroPagina - 1) * parametrosPaginacao.TamanhoPagina)
                                .Take(parametrosPaginacao.TamanhoPagina)
                                .ToList();
        return _mapper.Map<List<AgendamentoDto>>(agendamentos);
    }

    public async Task<List<AgendamentoDto>> TodosPorDataAsync(DateTime dataInicial, DateTime dataFinal)
    {
        var agendamentos = await TodosAsync();
        agendamentos = agendamentos.Where(a =>
                                a.DataAtendimento.Date >= dataInicial.Date
                                && a.DataAtendimento.Date <= dataFinal.Date
                                && a.StatusAtendimento == EStatusAtendimento.Finalizado)
                                .ToList();
        return _mapper.Map<List<AgendamentoDto>>(agendamentos);
    }

    public async Task<List<AgendamentoDto>> TodosAsync(ParametrosPaginacao parametrosPaginacao)
    {
        var agendamentos = await TodosAsync();
        return _mapper.Map<List<AgendamentoDto>>(agendamentos
                                                .Skip((parametrosPaginacao.NumeroPagina - 1) * parametrosPaginacao.TamanhoPagina)
                                                .Take(parametrosPaginacao.TamanhoPagina)
                                                .ToList());
    }
}
