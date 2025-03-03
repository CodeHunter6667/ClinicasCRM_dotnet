using System.Security.Claims;
using AutoMapper;
using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Servicos.Base;
using ClinicasCRM.Api.Servicos.Paciente.Interfaces;
using ClinicasCRM.Core.Dtos.Paciente;
using ClinicasCRM.Core.Exceptions;
using ClinicasCRM.Core.Models.Paciente;
using Microsoft.EntityFrameworkCore;

namespace ClinicasCRM.Api.Servicos.Paciente;

public class HabitosFemininosService : BaseService<HabitosFemininos>, IHabitosFemininosService
{
    private IMapper _mapper;
    public HabitosFemininosService(AppDbContext context, IMapper mapper) : base(context)
    {
        _mapper = mapper;
    }

    public async Task<FemaleHabitsDto> AtualizarAsync(long id, FemaleHabitsDto dto)
    {
        var habitos = await ObterAsync(id, dto.UsuarioId);
        if (habitos is null)
            throw new NotFoundException("Hábitos femininos não encontrados");
        _mapper.Map(dto, habitos);
        habitos = await AtualizarAsync(habitos);
        return _mapper.Map<FemaleHabitsDto>(habitos);
    }

    public async Task<FemaleHabitsDto> InserirAsync(FemaleHabitsDto dto)
    {
        var habitos = new HabitosFemininos();
        _mapper.Map(dto, habitos);
        habitos = await InserirAsync(habitos);
        return _mapper.Map<FemaleHabitsDto>(habitos);
    }

    public async Task<List<FemaleHabitsDto>> ObterPorCliente(long clienteId, string usuarioId)
    {
        var habitos = _context.FemaleHabits
        .AsNoTracking()
        .Where(x =>
        x.ClienteId == clienteId
        && x.UsuarioId.Equals(usuarioId, StringComparison.InvariantCultureIgnoreCase));
        return _mapper.Map<List<FemaleHabitsDto>>(await habitos.ToListAsync());
    }

    public async Task<FemaleHabitsDto> ObterPorIdAsync(long id, string usuarioId)
    {
        var habitos = await ObterAsync(id, usuarioId);
        if (habitos is null)
            throw new NotFoundException("Hábitos femininos não encontrados");
        return _mapper.Map<FemaleHabitsDto>(habitos);
    }

    public async Task<List<FemaleHabitsDto>> TodosAsync(string usuarioId)
    {
        var habitos = _context.FemaleHabits
        .AsNoTracking()
        .Where(x =>
        x.UsuarioId.Equals(usuarioId, StringComparison.InvariantCultureIgnoreCase));
        return _mapper.Map<List<FemaleHabitsDto>>(await habitos.ToListAsync());
    }
}
