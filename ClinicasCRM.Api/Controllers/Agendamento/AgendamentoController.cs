using ClinicasCRM.Api.Servicos.Agendamento.Interfaces;
using ClinicasCRM.Core.Common;
using ClinicasCRM.Core.Dtos.Agendamento;
using Microsoft.AspNetCore.Mvc;

namespace ClinicasCRM.Api.Controllers.Agendamento;

[ApiController]
[Route("api/v1/agendamento")]
public class AgendamentoController : ControllerBase
{
    private readonly IAgendamentoService _agendamentoService;

    public AgendamentoController(IAgendamentoService agendamentoService)
    {
        _agendamentoService = agendamentoService;
    }

    [HttpPost]
    public async Task<IActionResult> Inserir(AgendamentoDto agendamentoDto)
    {
        if (agendamentoDto is null) return BadRequest("Agendamento inválido");
        var agendamento = await _agendamentoService.InserirAsync(agendamentoDto);
        return new CreatedAtRouteResult("ObterPorId", new { id = agendamento.Id }, agendamento);
    }

    [HttpGet]
    public async Task<IActionResult> TodosAsync()
    {
        return Ok(await _agendamentoService.TodosAsync());
    }

    [HttpGet("{id:long}", Name = "ObterPorId")]
    public async Task<IActionResult> ObterPorId(long id)
    {
        var agendamento = await _agendamentoService.ObterPorIdAsync(id);
        if (agendamento is null) return NotFound("Agendamento não encontrado");
        return Ok(agendamento);
    }

    [HttpGet("data/{data:datetime}")]
    public async Task<IActionResult> ObterPorData([FromQuery] DateTime data, [FromQuery] ParametrosPaginacao parametrosPaginacao)
    {
        return Ok(await _agendamentoService.TodosPorDataAsync(data, parametrosPaginacao));
    }

    [HttpPut]
    public async Task<IActionResult> Atualizar(AgendamentoDto agendamentoDto)
    {
        if (agendamentoDto is null) return BadRequest("Agendamento inválido");
        var agendamento = await _agendamentoService.AtualizarAsync(agendamentoDto);
        return Ok(agendamento);
    }

    [HttpGet("cliente/{clienteId:long}")]
    public async Task<IActionResult> TodosPorCliente(long clienteId, ParametrosPaginacao parametrosPaginacao)
    {
        return Ok(await _agendamentoService.TodosPorClienteAsync(clienteId, parametrosPaginacao));
    }

    [HttpGet("periodoData")]
    public async Task<IActionResult> TodosPorData([FromQuery] DateTime dataInicial, [FromQuery] DateTime dataFinal)
    {
        return Ok(await _agendamentoService.TodosPorDataAsync(dataInicial, dataFinal));
    }

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Excluir(long id)
    {
        await _agendamentoService.DeletarAsync(id);
        return Ok();
    }
}