using System.Security.Claims;
using ClinicasCRM.Api.Servicos.Paciente.Interfaces;
using ClinicasCRM.Core.Dtos.Paciente;
using Microsoft.AspNetCore.Mvc;

namespace ClinicasCRM.Api.Controllers.Paciente;

[ApiController]
[Route("api/v1/[controller]")]
public class HabitosFemininosController : ControllerBase
{
    private readonly IHabitosFemininosService _habitosFemininosService;

    public HabitosFemininosController(IHabitosFemininosService habitosFemininosService)
    {
        _habitosFemininosService = habitosFemininosService;
    }

    public async Task<IActionResult> Todos(ClaimsPrincipal usuario)
    {
        return Ok(await _habitosFemininosService.TodosAsync(usuario.Identity?.Name ?? string.Empty));
    }

    [HttpGet("{id:long}", Name = "ObterPorId")]
    public async Task<IActionResult> ObterPorId(long id, ClaimsPrincipal usuario)
    {
        var habitosFemininos = await _habitosFemininosService.ObterPorIdAsync(id, usuario.Identity?.Name ?? string.Empty);
        if (habitosFemininos is null) return NotFound("Hábitos femininos não encontrados");
        return Ok(habitosFemininos);
    }

    [HttpGet("cliente/{clienteId:long}")]
    public async Task<IActionResult> ObterPorCliente(long clienteId, ClaimsPrincipal usuario)
    {
        return Ok(await _habitosFemininosService.ObterPorCliente(clienteId, usuario.Identity?.Name ?? string.Empty));
    }

    [HttpPost]
    public async Task<IActionResult> Inserir(FemaleHabitsDto femaleHabitsDto)
    {
        if (femaleHabitsDto is null) return BadRequest("Hábitos femininos inválidos");
        var habitosFemininos = await _habitosFemininosService.InserirAsync(femaleHabitsDto);
        return new CreatedAtRouteResult("ObterPorId", new { id = habitosFemininos.Id }, habitosFemininos);
    }

    [HttpPut("{id:long}")]
    public async Task<IActionResult> Atualizar(long id, FemaleHabitsDto femaleHabitsDto)
    {
        if (femaleHabitsDto is null) return BadRequest("Hábitos femininos inválidos");
        var habitosFemininos = await _habitosFemininosService.AtualizarAsync(id, femaleHabitsDto);
        return Ok(habitosFemininos);
    }

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Deletar(long id, ClaimsPrincipal usuario)
    {
        await _habitosFemininosService.DeletarAsync(id, usuario.Identity?.Name ?? string.Empty);
        return NoContent();
    }
}
