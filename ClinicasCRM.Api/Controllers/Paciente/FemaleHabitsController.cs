using System.Security.Claims;
using ClinicasCRM.Api.Services.Patient.Interfaces;
using ClinicasCRM.Core.Dtos.Patient;
using Microsoft.AspNetCore.Mvc;

namespace ClinicasCRM.Api.Controllers.Paciente;

[ApiController]
[Route("api/v1/[controller]")]
public class FemaleHabitsController : ControllerBase
{
    private readonly IFemaleHabitsService _femaleHabitsService;

    public FemaleHabitsController(IFemaleHabitsService femaleHabitsService)
    {
        _femaleHabitsService = femaleHabitsService;
    }

    [HttpGet]
    public async Task<IActionResult> Todos(ClaimsPrincipal user)
    {
        return Ok(await _femaleHabitsService.GetAllAsync(user.Identity?.Name ?? string.Empty));
    }

    [HttpGet("{id:long}", Name = "GetById")]
    public async Task<IActionResult> ObterPorId(long id, ClaimsPrincipal user)
    {
        var femaleHabits = await _femaleHabitsService.GetByIdAsync(id, user.Identity?.Name ?? string.Empty);
        if (femaleHabits is null) return NotFound("Hábitos femininos não encontrados");
        return Ok(femaleHabits);
    }

    [HttpGet("cliente/{clienteId:long}")]
    public async Task<IActionResult> ObterPorCliente(long clientId, ClaimsPrincipal user)
    {
        return Ok(await _femaleHabitsService.GetByClientAsync(clientId, user.Identity?.Name ?? string.Empty));
    }

    [HttpPost]
    public async Task<IActionResult> Inserir(FemaleHabitsDto dto, ClaimsPrincipal user)
    {
        if (dto is null) return BadRequest("Hábitos femininos inválidos");
        var femaleHabits = await _femaleHabitsService.InsertAsync(dto, "teste", user.Identity?.Name ?? string.Empty);
        return new CreatedAtRouteResult("GetById", new { id = femaleHabits.Id }, femaleHabits);
    }

    [HttpPut("{id:long}")]
    public async Task<IActionResult> Atualizar(long id, FemaleHabitsDto dto, ClaimsPrincipal user)
    {
        if (dto is null) return BadRequest("Hábitos femininos inválidos");
        var femaleHabits = await _femaleHabitsService.UpdateAsync(id, dto, "teste", user.Identity?.Name ?? string.Empty);
        return Ok(femaleHabits);
    }

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Deletar(long id, ClaimsPrincipal user)
    {
        await _femaleHabitsService.Delete(id, user.Identity?.Name ?? string.Empty);
        return NoContent();
    }
}
