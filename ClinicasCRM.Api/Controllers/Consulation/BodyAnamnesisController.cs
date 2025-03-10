using ClinicasCRM.Api.Services.Consulation.Interfaces;
using ClinicasCRM.Core.Dtos.Consulation;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ClinicasCRM.Api.Controllers.Consulation;

[ApiController]
[Route("api/v1/[controller]")]
public class BodyAnamnesisController : ControllerBase
{
    private readonly IBodyAnamnesisService _bodyAnamnesisService;

    public BodyAnamnesisController(IBodyAnamnesisService bodyAnamnesisService)
    {
        _bodyAnamnesisService = bodyAnamnesisService;
    }

    [HttpGet]
    public async Task<IActionResult> Todos(ClaimsPrincipal user)
    {
        return Ok(await _bodyAnamnesisService.GetAllAsync(user.Identity?.Name ?? string.Empty));
    }

    [HttpGet("{id:long}", Name = "GetById")]
    public async Task<IActionResult> ObterPorId(long id, ClaimsPrincipal user)
    {
        var bodyAnamnese = await _bodyAnamnesisService.GetByIdAsync(id, user.Identity?.Name ?? string.Empty);
        if (bodyAnamnese is null) return NotFound("Anamnese corporal não encontrada");
        return Ok(bodyAnamnese);
    }

    [HttpPost]
    public async Task<IActionResult> Inserir(BodyAnamnesisDto dto, ClaimsPrincipal user)
    {
        if (dto is null) return BadRequest("Anamnese corporal inválida");
        var bodyAnamnese = await _bodyAnamnesisService.InsertAsync(dto, "teste", user.Identity?.Name ?? string.Empty);
        return new CreatedAtRouteResult("GetById", new { id = bodyAnamnese.Id }, bodyAnamnese);
    }

    [HttpPut("{id:long}")]
    public async Task<IActionResult> Atualizar(long id, BodyAnamnesisDto dto, ClaimsPrincipal user)
    {
        if (dto is null) return BadRequest("Anamnese corporal inválida");
        var anamneseCorporal = await _bodyAnamnesisService.UpdateAsync(id, dto, "teste", user.Identity?.Name ?? string.Empty);
        return Ok(anamneseCorporal);
    }

    [HttpGet("cliente/{clienteId:long}")]
    public async Task<IActionResult> TodosPorCliente(long clienteId, ClaimsPrincipal user)
    {
        return Ok(await _bodyAnamnesisService.GetAllByClientAsync(clienteId, user.Identity?.Name ?? string.Empty));
    }

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Deletar(long id, ClaimsPrincipal user)
    {
        await _bodyAnamnesisService.Delete(id, user.Identity?.Name ?? string.Empty);
        return NoContent();
    }
}
