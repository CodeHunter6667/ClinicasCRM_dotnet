using System.Security.Claims;
using ClinicasCRM.Api.Servicos.Consulta.Interfaces;
using ClinicasCRM.Core.Dtos.Consulta;
using Microsoft.AspNetCore.Mvc;

namespace ClinicasCRM.Api.Controllers.Consulta;

[ApiController]
[Route("api/v1/[controller]")]
public class AnamneseFacialController : ControllerBase
{
    private readonly IAnamneseFacialService _anamneseFacialService;

    public AnamneseFacialController(IAnamneseFacialService anamneseFacialService)
    {
        _anamneseFacialService = anamneseFacialService;
    }

    [HttpGet]
    public async Task<IActionResult> Todos(ClaimsPrincipal usuario)
    {
        return Ok(await _anamneseFacialService.TodosAsync(usuario.Identity?.Name ?? string.Empty));
    }

    [HttpGet("{id:long}", Name = "ObterPorId")]
    public async Task<IActionResult> ObterPorId(long id, ClaimsPrincipal usuario)
    {
        var anamneseFacial = await _anamneseFacialService.ObterPorIdAsync(id, usuario.Identity?.Name ?? string.Empty);
        if (anamneseFacial is null) return NotFound("Anamnese facial não encontrada");
        return Ok(anamneseFacial);
    }

    [HttpGet("cliente/{clienteId:long}")]
    public async Task<IActionResult> TodosPorCliente(long clienteId, ClaimsPrincipal usuario)
    {
        return Ok(await _anamneseFacialService.TodosPorClienteAsync(clienteId, usuario.Identity?.Name ?? string.Empty));
    }

    [HttpPost]
    public async Task<IActionResult> Inserir(AnamneseFacialDto dto)
    {
        if (dto is null) return BadRequest("Anamnese facial inválida");
        var anamneseFacial = await _anamneseFacialService.InserirAsync(dto);
        return new CreatedAtRouteResult("ObterPorId", new { id = anamneseFacial.Id }, anamneseFacial);
    }

    [HttpPut("{id:long}")]
    public async Task<IActionResult> Atualizar(long id, AnamneseFacialDto dto)
    {
        if (dto is null) return BadRequest("Anamnese facial inválida");
        var anamneseFacial = await _anamneseFacialService.AtualizarAsync(id, dto);
        return Ok(anamneseFacial);
    }

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Deletar(long id, ClaimsPrincipal usuario)
    {
        await _anamneseFacialService.DeletarAsync(id, usuario.Identity?.Name ?? string.Empty);
        return NoContent();
    }
}
