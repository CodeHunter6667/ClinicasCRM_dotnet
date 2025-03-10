using System.Security.Claims;
using ClinicasCRM.Api.Services.Patient.Interfaces;
using ClinicasCRM.Core.Dtos.Patient;
using Microsoft.AspNetCore.Mvc;

namespace ClinicasCRM.Api.Controllers.Patient;

[ApiController]
[Route("api/v1/[controller]")]
public class PatientHistoryController : ControllerBase
{
    private readonly IPatientHistoryService _patientHistoryService;

    public PatientHistoryController(IPatientHistoryService patientHistoryService)
    {
        _patientHistoryService = patientHistoryService;
    }

    [HttpGet]
    public async Task<IActionResult> Todos(ClaimsPrincipal user)
    {
        return Ok(await _patientHistoryService.GetAllAsync(user.Identity?.Name ?? string.Empty));
    }

    [HttpGet("{id:long}", Name = "GetById")]
    public async Task<IActionResult> ObterPorId(long id, ClaimsPrincipal user)
    {
        var patientHistory = await _patientHistoryService.GetByIdAsync(id, user.Identity?.Name ?? string.Empty);
        return patientHistory == null ? NotFound("Historico não encontrado") : Ok(patientHistory);
    }

    [HttpGet("cliente/{clientId:long}")]
    public async Task<IActionResult> ObterPOrCliente(long clientId, ClaimsPrincipal user)
    {
        var patientHistory = await _patientHistoryService.GetByClientAsync(clientId, user.Identity?.Name ?? string.Empty);
        return patientHistory == null ? NotFound("Historico não encontrado") : Ok(patientHistory);
    }

    [HttpPost]
    public async Task<IActionResult> Inserir(PatientHistoryDto dto, ClaimsPrincipal user)
    {
        var patientHistory = await _patientHistoryService.InsertAsync(dto, "teste", user.Identity?.Name ?? string.Empty);
        return new CreatedAtRouteResult("GetById", new { id = patientHistory.Id }, patientHistory);
    }

    [HttpPut("{id:long}")]
    public async Task<IActionResult> Atualizar(long id, PatientHistoryDto dto, ClaimsPrincipal user)
    {
        var patientHistory = await _patientHistoryService.UpdateAsync(id, dto, "teste", user.Identity?.Name ?? string.Empty);
        return patientHistory == null ? NotFound("Historico não encontrado") : Ok(patientHistory);
    }

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Deletar(long id, ClaimsPrincipal user)
    {
        await _patientHistoryService.Delete(id, user.Identity?.Name ?? string.Empty);
        return NoContent();
    }
}
