using ClinicasCRM.Api.Servicos.Agendamento.Interfaces;
using ClinicasCRM.Core.Common;
using ClinicasCRM.Core.Dtos.Agendamento;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
    public async Task<IActionResult> TodosAsync(ClaimsPrincipal usuario)
    {
        return Ok(await _agendamentoService.TodosAsync(usuario.Identity?.Name ?? string.Empty));
    }

    [HttpGet("{id:long}", Name = "ObterPorId")]
    public async Task<IActionResult> ObterPorId(long id, ClaimsPrincipal usuario)
    {
        var agendamento = await _agendamentoService.ObterPorIdAsync(id, usuario.Identity?.Name ?? string.Empty);
        if (agendamento is null) return NotFound("Agendamento não encontrado");
        return Ok(agendamento);
    }

    [HttpGet("data/{data:datetime}")]
    public async Task<IActionResult> ObterPorData([FromQuery] DateTime data, [FromQuery] ParametrosPaginacao parametrosPaginacao, ClaimsPrincipal usuario)
    {
        return Ok(await _agendamentoService.TodosPorDataAsync(data, usuario.Identity?.Name ?? string.Empty, parametrosPaginacao));
    }

    [HttpPut]
    public async Task<IActionResult> Atualizar(AgendamentoDto agendamentoDto)
    {
        if (agendamentoDto is null) return BadRequest("Agendamento inválido");
        var agendamento = await _agendamentoService.AtualizarAsync(agendamentoDto);
        return Ok(agendamento);
    }

    [HttpGet("cliente/{clienteId:long}")]
    public async Task<IActionResult> TodosPorCliente(long clienteId, ParametrosPaginacao parametrosPaginacao, ClaimsPrincipal usuario)
    {
        return Ok(await _agendamentoService.TodosPorClienteAsync(clienteId, usuario.Identity?.Name ?? string.Empty, parametrosPaginacao));
    }

    [HttpGet("periodoData")]
    public async Task<IActionResult> TodosPorData([FromQuery] DateTime dataInicial, [FromQuery] DateTime dataFinal, ClaimsPrincipal usuario)
    {
        return Ok(await _agendamentoService.TodosPorDataAsync(dataInicial, dataFinal, usuario.Identity?.Name ?? string.Empty));
    }

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Excluir(long id, ClaimsPrincipal usuario)
    {
        await _agendamentoService.DeletarAsync(id, usuario.Identity?.Name ?? string.Empty);
        return NoContent();
    }
}