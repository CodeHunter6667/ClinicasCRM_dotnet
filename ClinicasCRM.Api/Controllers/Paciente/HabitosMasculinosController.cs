using System.Security.Claims;
using ClinicasCRM.Api.Servicos.Paciente.Interfaces;
using ClinicasCRM.Core.Dtos.Paciente;
using Microsoft.AspNetCore.Mvc;

namespace ClinicasCRM.Api.Controllers.Paciente;

[ApiController]
[Route("api/v1/[controller]")]
public class HabitosMasculinosController : ControllerBase
{
    private readonly IHabitosMasculinosService _habitosMasculinosService;

    public HabitosMasculinosController(IHabitosMasculinosService habitosMasculinosService)
    {
        _habitosMasculinosService = habitosMasculinosService;
    }

    [HttpGet]
    public async Task<IActionResult> Todos(ClaimsPrincipal usuario)
    {
        return Ok(await _habitosMasculinosService.TodosAsync(usuario.Identity?.Name ?? string.Empty));
    }

    [HttpGet("{id:long}", Name = "ObterPorId")]
    public async Task<IActionResult> ObterPorId(long id, ClaimsPrincipal usuario)
    {
        var habitosMasculinos = await _habitosMasculinosService.ObterPorIdAsync(id, usuario.Identity?.Name ?? string.Empty);
        if (habitosMasculinos is null) return NotFound("Hábitos masculinos não encontrados");
        return Ok(habitosMasculinos);
    }

    [HttpGet("cliente/{clienteId:long}")]
    public async Task<IActionResult> ObterPorCliente(long clienteId, ClaimsPrincipal usuario)
    {
        var habitos = await _habitosMasculinosService.ObterPorClienteAsync(clienteId, usuario.Identity?.Name ?? string.Empty);
        if (habitos is null) return NotFound("Hábitos masculinos não encontrados");
        return Ok(habitos);
    }

    [HttpPost]
    public async Task<IActionResult> Inserir(HabitosMasculinosDto dto)
    {
        var habitos = await _habitosMasculinosService.InserirAsync(dto);
        return new CreatedAtRouteResult("ObterPorId", new { id = habitos.Id }, habitos);
    }

    [HttpPut("{id:long}")]
    public async Task<IActionResult> Atualizar(long id, HabitosMasculinosDto dto)
    {
        var habitos = await _habitosMasculinosService.AtualizarAsync(id, dto);
        return Ok(habitos);
    }

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Deletar(long id, ClaimsPrincipal usuario)
    {
        await _habitosMasculinosService.DeletarAsync(id, usuario.Identity?.Name ?? string.Empty);
        return NoContent();
    }
}
