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

public class HabitosFemininosService : ServicoBase<HabitosFemininos>, IHabitosFemininosService
{
    private IMapper _mapper;
    public HabitosFemininosService(AppDbContext context, IMapper mapper) : base(context)
    {
        _mapper = mapper;
    }

    public async Task<HabitosFemininosDto> AtualizarAsync(long id, HabitosFemininosDto dto)
    {
        var habitos = await ObterAsync(id, dto.UsuarioId);
        if (habitos is null)
            throw new NotFoundException("Hábitos femininos não encontrados");
        _mapper.Map(dto, habitos);
        habitos = await AtualizarAsync(habitos);
        return _mapper.Map<HabitosFemininosDto>(habitos);
    }

    public async Task<HabitosFemininosDto> InserirAsync(HabitosFemininosDto dto)
    {
        var habitos = new HabitosFemininos();
        _mapper.Map(dto, habitos);
        habitos = await InserirAsync(habitos);
        return _mapper.Map<HabitosFemininosDto>(habitos);
    }

    public async Task<List<HabitosFemininosDto>> ObterPorCliente(long clienteId, string usuarioId)
    {
        var habitos = _context.HabitosFemininos
        .AsNoTracking()
        .Where(x =>
        x.ClienteId == clienteId
        && x.UsuarioId.Equals(usuarioId, StringComparison.InvariantCultureIgnoreCase));
        return _mapper.Map<List<HabitosFemininosDto>>(await habitos.ToListAsync());
    }

    public async Task<HabitosFemininosDto> ObterPorIdAsync(long id, string usuarioId)
    {
        var habitos = await ObterAsync(id, usuarioId);
        if (habitos is null)
            throw new NotFoundException("Hábitos femininos não encontrados");
        return _mapper.Map<HabitosFemininosDto>(habitos);
    }

    public async Task<List<HabitosFemininosDto>> TodosAsync(string usuarioId)
    {
        var habitos = _context.HabitosFemininos
        .AsNoTracking()
        .Where(x =>
        x.UsuarioId.Equals(usuarioId, StringComparison.InvariantCultureIgnoreCase));
        return _mapper.Map<List<HabitosFemininosDto>>(await habitos.ToListAsync());
    }
}
