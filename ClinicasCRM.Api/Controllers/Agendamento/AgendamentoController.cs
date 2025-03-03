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
    private readonly IProcedureService _procedureService;

    public AgendamentoController(IProcedureService procedureService)
    {
        _procedureService = procedureService;
    }

    [HttpPost]
    public async Task<IActionResult> Inserir(AgendamentoDto agendamentoDto)
    {
        if (agendamentoDto is null) return BadRequest("Agendamento inválido");
        var agendamento = await _procedureService.InserirAsync(agendamentoDto);
        return new CreatedAtRouteResult("ObterPorId", new { id = agendamento.Id }, agendamento);
    }

    [HttpGet]
    public async Task<IActionResult> TodosAsync(ClaimsPrincipal usuario)
    {
        return Ok(await _procedureService.TodosAsync(usuario.Identity?.Name ?? string.Empty));
    }

    [HttpGet("{id:long}", Name = "ObterPorId")]
    public async Task<IActionResult> ObterPorId(long id, ClaimsPrincipal usuario)
    {
        var agendamento = await _procedureService.ObterPorIdAsync(id, usuario.Identity?.Name ?? string.Empty);
        if (agendamento is null) return NotFound("Agendamento não encontrado");
        return Ok(agendamento);
    }

    [HttpGet("data/{data:datetime}")]
    public async Task<IActionResult> ObterPorData([FromQuery] DateTime data, [FromQuery] PaginationParameters paginationParameters, ClaimsPrincipal usuario)
    {
        return Ok(await _procedureService.TodosPorDataAsync(data, usuario.Identity?.Name ?? string.Empty, paginationParameters));
    }

    [HttpPut("{id:long}")]
    public async Task<IActionResult> Atualizar(long id, AgendamentoDto agendamentoDto)
    {
        if (agendamentoDto is null) return BadRequest("Agendamento inválido");
        var agendamento = await _procedureService.AtualizarAsync(id, agendamentoDto);
        return Ok(agendamento);
    }

    [HttpGet("cliente/{clienteId:long}")]
    public async Task<IActionResult> TodosPorCliente(long clienteId, PaginationParameters paginationParameters, ClaimsPrincipal usuario)
    {
        return Ok(await _procedureService.TodosPorClienteAsync(clienteId, usuario.Identity?.Name ?? string.Empty, paginationParameters));
    }

    [HttpGet("periodoData")]
    public async Task<IActionResult> TodosPorData([FromQuery] DateTime dataInicial, [FromQuery] DateTime dataFinal, ClaimsPrincipal usuario)
    {
        return Ok(await _procedureService.TodosPorDataAsync(dataInicial, dataFinal, usuario.Identity?.Name ?? string.Empty));
    }

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Excluir(long id, ClaimsPrincipal usuario)
    {
        await _procedureService.DeletarAsync(id, usuario.Identity?.Name ?? string.Empty);
        return NoContent();
    }
}