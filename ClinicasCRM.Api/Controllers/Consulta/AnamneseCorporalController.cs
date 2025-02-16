using ClinicasCRM.Api.Servicos.Consulta.Interfaces;
using ClinicasCRM.Core.Dtos.Consulta;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ClinicasCRM.Api.Controllers.Consulta;

[ApiController]
[Route("api/v1/[controller]")]
public class AnamneseCorporalController : ControllerBase
{
    private readonly IAnamneseCorporalService _anamneseCorporalService;

    public AnamneseCorporalController(IAnamneseCorporalService anamneseCorporalService)
    {
        _anamneseCorporalService = anamneseCorporalService;
    }

    [HttpGet]
    public async Task<IActionResult> Todos(ClaimsPrincipal usuario)
    {
        return Ok(await _anamneseCorporalService.TodosAsync(usuario.Identity?.Name ?? string.Empty));
    }

    [HttpGet("{id:long}")]
    public async Task<IActionResult> ObterPorId(long id, ClaimsPrincipal usuario)
    {
        var anamneseCorporal = await _anamneseCorporalService.ObterPorId(id, usuario.Identity?.Name ?? string.Empty);
        if (anamneseCorporal is null) return NotFound("Anamnese corporal não encontrada");
        return Ok(anamneseCorporal);
    }

    [HttpPost]
    public async Task<IActionResult> Inserir(AnamneseCorporalDto anamneseCorporalDto)
    {
        if (anamneseCorporalDto is null) return BadRequest("Anamnese corporal inválida");
        var anamneseCorporal = await _anamneseCorporalService.InserirAsync(anamneseCorporalDto);
        return new CreatedAtRouteResult("ObterPorId", new { id = anamneseCorporal.Id }, anamneseCorporal);
    }

    [HttpPut("{id:long}")]
    public async Task<IActionResult> Atualizar(long id, AnamneseCorporalDto anamneseCorporalDto)
    {
        if (anamneseCorporalDto is null) return BadRequest("Anamnese corporal inválida");
        var anamneseCorporal = await _anamneseCorporalService.AtualizarAsync(id, anamneseCorporalDto);
        return Ok(anamneseCorporal);
    }

    [HttpGet("cliente/{clienteId:long}")]
    public async Task<IActionResult> TodosPorCliente(long clienteId, ClaimsPrincipal usuario)
    {
        return Ok(await _anamneseCorporalService.TodosPorCliente(clienteId, usuario.Identity?.Name ?? string.Empty));
    }

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Deletar(long id, ClaimsPrincipal usuario)
    {
        await _anamneseCorporalService.DeletarAsync(id, usuario.Identity?.Name ?? string.Empty);
        return NoContent();
    }
}
