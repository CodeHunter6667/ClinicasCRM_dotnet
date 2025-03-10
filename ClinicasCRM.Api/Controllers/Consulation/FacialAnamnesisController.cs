using System.Security.Claims;
using ClinicasCRM.Api.Services.Consulation.Interfaces;
using ClinicasCRM.Core.Dtos.Consulation;
using Microsoft.AspNetCore.Mvc;

namespace ClinicasCRM.Api.Controllers.Consulation;

[ApiController]
[Route("api/v1/[controller]")]
public class FacialAnamnesisController : ControllerBase
{
    private readonly IFacialAnamnesisService _facialAnamnesisService;

    public FacialAnamnesisController(IFacialAnamnesisService facialAnamnesisService)
    {
        _facialAnamnesisService = facialAnamnesisService;
    }

    [HttpGet]
    public async Task<IActionResult> Todos(ClaimsPrincipal user)
    {
        return Ok(await _facialAnamnesisService.GetAllAsync(user.Identity?.Name ?? string.Empty));
    }

    [HttpGet("{id:long}", Name = "ObterPorId")]
    public async Task<IActionResult> ObterPorId(long id, ClaimsPrincipal user)
    {
        var facialAnamnese = await _facialAnamnesisService.GetByIdAsync(id, user.Identity?.Name ?? string.Empty);
        if (facialAnamnese is null) return NotFound("Anamnese facial não encontrada");
        return Ok(facialAnamnese);
    }

    [HttpGet("cliente/{clientId:long}")]
    public async Task<IActionResult> TodosPorCliente(long clientId, ClaimsPrincipal user)
    {
        return Ok(await _facialAnamnesisService.GetAllByClientAsync(clientId, user.Identity?.Name ?? string.Empty));
    }

    [HttpPost]
    public async Task<IActionResult> Inserir(FacialAnamnesisDto dto, ClaimsPrincipal user)
    {
        if (dto is null) return BadRequest("Anamnese facial inválida");
        var facialAnamnese = await _facialAnamnesisService.InsertAsync(dto, "teste", user.Identity?.Name ?? string.Empty);
        return new CreatedAtRouteResult("ObterPorId", new { id = facialAnamnese.Id }, facialAnamnese);
    }

    [HttpPut("{id:long}")]
    public async Task<IActionResult> Atualizar(long id, FacialAnamnesisDto dto, ClaimsPrincipal user)
    {
        if (dto is null) return BadRequest("Anamnese facial inválida");
        var facialAnamnese = await _facialAnamnesisService.UpdateAsync(id, dto, "teste", user.Identity?.Name ?? string.Empty);
        return Ok(facialAnamnese);
    }

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Deletar(long id, ClaimsPrincipal user)
    {
        await _facialAnamnesisService.Delete(id, user.Identity?.Name ?? string.Empty);
        return NoContent();
    }
}
