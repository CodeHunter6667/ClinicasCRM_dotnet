using ClinicasCRM.Api.Servicos.Consulta.Interfaces;
using ClinicasCRM.Core.Dtos.Consulta;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ClinicasCRM.Api.Controllers.Consulta;

[ApiController]
[Route("api/v1/[controller]")]
public class AnamneseCorporalController : ControllerBase
{
    private readonly IBodyAnamnesisService _bodyAnamnesisService;

    public AnamneseCorporalController(IBodyAnamnesisService bodyAnamnesisService)
    {
        _bodyAnamnesisService = bodyAnamnesisService;
    }

    [HttpGet]
    public async Task<IActionResult> Todos(ClaimsPrincipal usuario)
    {
        return Ok(await _bodyAnamnesisService.GetAllAsync(usuario.Identity?.Name ?? string.Empty));
    }

    [HttpGet("{id:long}")]
    public async Task<IActionResult> ObterPorId(long id, ClaimsPrincipal usuario)
    {
        var anamneseCorporal = await _bodyAnamnesisService.GetByIdAsync(id, usuario.Identity?.Name ?? string.Empty);
        if (anamneseCorporal is null) return NotFound("Anamnese corporal não encontrada");
        return Ok(anamneseCorporal);
    }

    [HttpPost]
    public async Task<IActionResult> Inserir(AnamneseCorporalDto anamneseCorporalDto)
    {
        if (anamneseCorporalDto is null) return BadRequest("Anamnese corporal inválida");
        var anamneseCorporal = await _bodyAnamnesisService.InsertAsync(anamneseCorporalDto);
        return new CreatedAtRouteResult("ObterPorId", new { id = anamneseCorporal.Id }, anamneseCorporal);
    }

    [HttpPut("{id:long}")]
    public async Task<IActionResult> Atualizar(long id, AnamneseCorporalDto anamneseCorporalDto)
    {
        if (anamneseCorporalDto is null) return BadRequest("Anamnese corporal inválida");
        var anamneseCorporal = await _bodyAnamnesisService.UpdateAsync(id, anamneseCorporalDto);
        return Ok(anamneseCorporal);
    }

    [HttpGet("cliente/{clienteId:long}")]
    public async Task<IActionResult> TodosPorCliente(long clienteId, ClaimsPrincipal usuario)
    {
        return Ok(await _bodyAnamnesisService.GetAllByClientAsync(clienteId, usuario.Identity?.Name ?? string.Empty));
    }

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Deletar(long id, ClaimsPrincipal usuario)
    {
        await _bodyAnamnesisService.DeletarAsync(id, usuario.Identity?.Name ?? string.Empty);
        return NoContent();
    }
}
