using System.Security.Claims;
using ClinicasCRM.Api.Servicos.Paciente.Interfaces;
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
}
