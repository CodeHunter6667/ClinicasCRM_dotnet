using ClinicasCRM.Api.Services.Appointment.Interfaces;
using ClinicasCRM.Core.Dtos.Appointment;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ClinicasCRM.Api.Controllers.Agendamento;

[ApiController]
[Route("api/v1/[controller]")]
public class AppointmentController : ControllerBase
{
    private readonly IAppointmentService _appointmentService;

    public AppointmentController(IAppointmentService appointmentService)
    {
        _appointmentService = appointmentService;
    }

    [HttpPost]
    public async Task<IActionResult> Inserir(AppointmentDto dto, ClaimsPrincipal user)
    {
        if (dto is null) return BadRequest("Agendamento inválido");
        var agendamento = await _appointmentService.InsertAsync(dto, "teste", user.Identity?.Name ?? string.Empty);
        return new CreatedAtRouteResult("GetById", new { id = agendamento.Id }, agendamento);
    }

    [HttpGet]
    public async Task<IActionResult> TodosAsync(ClaimsPrincipal usuario, [FromQuery] int pageSize, [FromQuery] int pageNumber)
    {
        return Ok(await _appointmentService.GetAllAsync(usuario.Identity?.Name ?? string.Empty, pageSize, pageNumber));
    }

    [HttpGet("{id:long}", Name = "GetById")]
    public async Task<IActionResult> ObterPorId(long id, ClaimsPrincipal user)
    {
        var agendamento = await _appointmentService.GetByIdAsync(id, user.Identity?.Name ?? string.Empty);
        if (agendamento is null) return NotFound("Agendamento não encontrado");
        return Ok(agendamento);
    }

    [HttpGet("data/{data:datetime}")]
    public async Task<IActionResult> ObterPorData([FromQuery] DateTime date, [FromQuery] int pageSize, [FromQuery] int pageNumber, ClaimsPrincipal usuario)
    {
        return Ok(await _appointmentService.GetAllByDateAsync(date, usuario.Identity?.Name ?? string.Empty, pageSize, pageNumber));
    }

    [HttpPut("{id:long}")]
    public async Task<IActionResult> Atualizar(long id, AppointmentDto dto, ClaimsPrincipal user)
    {
        if (dto is null) return BadRequest("Agendamento inválido");
        var agendamento = await _appointmentService.UpdateAsync(id, dto, "teste", user.Identity?.Name ?? string.Empty);
        return Ok(agendamento);
    }

    [HttpGet("cliente/{clienteId:long}")]
    public async Task<IActionResult> TodosPorCliente(long clienteId, [FromQuery] int pageSize, [FromQuery] int pageNumber, ClaimsPrincipal user)
    {
        return Ok(await _appointmentService.GetAllByClientAsync(clienteId, user.Identity?.Name ?? string.Empty, pageSize, pageNumber));
    }

    [HttpGet("periodoData")]
    public async Task<IActionResult> TodosPorData([FromQuery] DateTime initialDate, [FromQuery] DateTime endDate, ClaimsPrincipal user)
    {
        return Ok(await _appointmentService.GetAllByDateAsync(initialDate, endDate, user.Identity?.Name ?? string.Empty));
    }

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Excluir(long id, ClaimsPrincipal user)
    {
        await _appointmentService.Delete(id, user.Identity?.Name ?? string.Empty);
        return NoContent();
    }
}