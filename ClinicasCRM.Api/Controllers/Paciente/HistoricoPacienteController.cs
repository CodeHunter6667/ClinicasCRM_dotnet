using System.Security.Claims;
using ClinicasCRM.Api.Servicos.Paciente.Interfaces;
using ClinicasCRM.Core.Dtos.Paciente;
using Microsoft.AspNetCore.Mvc;

namespace ClinicasCRM.Api.Controllers.Paciente;

[ApiController]
[Route("api/v1/[controller]")]
public class HistoricoPacienteController : ControllerBase
{
    private readonly IHistoricoPacienteService _historicoPacienteService;

    public HistoricoPacienteController(IHistoricoPacienteService historicoPacienteService)
    {
        _historicoPacienteService = historicoPacienteService;
    }

    [HttpGet]
    public async Task<IActionResult> Todos(ClaimsPrincipal usuario)
    {
        return Ok(await _historicoPacienteService.TodosAsync(usuario.Identity?.Name ?? string.Empty));
    }

    [HttpGet("{id:long}", Name = "ObterPorId")]
    public async Task<IActionResult> ObterPorId(long id, ClaimsPrincipal usuario)
    {
        var historico = await _historicoPacienteService.ObterPorIdAsync(id, usuario.Identity?.Name ?? string.Empty);
        return historico == null ? NotFound("Historico não encontrado") : Ok(historico);
    }

    [HttpGet("cliente/{clienteId:long}")]
    public async Task<IActionResult> ObterPOrCliente(long clienteId, ClaimsPrincipal usuario)
    {
        var historico = await _historicoPacienteService.ObterPorClienteAsync(clienteId, usuario.Identity?.Name ?? string.Empty);
        return historico == null ? NotFound("Historico não encontrado") : Ok(historico);
    }

    [HttpPost]
    public async Task<IActionResult> Inserir(HistoricoPacienteDto dto)
    {
        var historico = await _historicoPacienteService.InserirAsync(dto);
        return new CreatedAtRouteResult("ObterPorId", new { id = historico.Id }, historico);
    }

    [HttpPut("{id:long}")]
    public async Task<IActionResult> Atualizar(long id, HistoricoPacienteDto dto)
    {
        var historico = await _historicoPacienteService.AtualizarAsync(id, dto);
        return historico == null ? NotFound("Historico não encontrado") : Ok(historico);
    }

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Deletar(long id, ClaimsPrincipal usuario)
    {
        await _historicoPacienteService.DeletarAsync(id, usuario.Identity?.Name ?? string.Empty);
        return NoContent();
    }
}
