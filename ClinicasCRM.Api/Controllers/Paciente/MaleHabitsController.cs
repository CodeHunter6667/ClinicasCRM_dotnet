using System.Security.Claims;
using ClinicasCRM.Api.Services.Patient.Interfaces;
using ClinicasCRM.Core.Dtos.Patient;
using Microsoft.AspNetCore.Mvc;

namespace ClinicasCRM.Api.Controllers.Paciente;

[ApiController]
[Route("api/v1/[controller]")]
public class MaleHabitsController : ControllerBase
{
    private readonly IMaleHabitsService _maleHabitsService;

    public MaleHabitsController(IMaleHabitsService maleHabitsService)
    {
        _maleHabitsService = maleHabitsService;
    }

    [HttpGet]
    public async Task<IActionResult> Todos(ClaimsPrincipal user)
    {
        return Ok(await _maleHabitsService.GetAllAsync(user.Identity?.Name ?? string.Empty));
    }

    [HttpGet("{id:long}", Name = "GetById")]
    public async Task<IActionResult> ObterPorId(long id, ClaimsPrincipal user)
    {
        var maleHabits = await _maleHabitsService.GetByIdAsync(id, user.Identity?.Name ?? string.Empty);
        if (maleHabits is null) return NotFound("Hábitos masculinos não encontrados");
        return Ok(maleHabits);
    }

    [HttpGet("cliente/{clientId:long}")]
    public async Task<IActionResult> ObterPorCliente(long clientId, ClaimsPrincipal user)
    {
        var maleHabits = await _maleHabitsService.GetByClientAsync(clientId, user.Identity?.Name ?? string.Empty);
        if (maleHabits is null) return NotFound("Hábitos masculinos não encontrados");
        return Ok(maleHabits);
    }

    [HttpPost]
    public async Task<IActionResult> Inserir(MaleHabitsDto dto, ClaimsPrincipal user)
    {
        var maleHabits = await _maleHabitsService.InsertAsync(dto, "teste", user.Identity?.Name ?? string.Empty);
        return new CreatedAtRouteResult("GetById", new { id = maleHabits.Id }, maleHabits);
    }

    [HttpPut("{id:long}")]
    public async Task<IActionResult> Atualizar(long id, MaleHabitsDto dto, ClaimsPrincipal user)
    {
        var maleHabits = await _maleHabitsService.UpdateAsync(id, dto, "teste", user.Identity?.Name ?? string.Empty);
        return Ok(maleHabits);
    }

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Deletar(long id, ClaimsPrincipal user)
    {
        await _maleHabitsService.Delete(id, user.Identity?.Name ?? string.Empty);
        return NoContent();
    }
}
