using AutoMapper;
using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Servicos.Base;
using ClinicasCRM.Api.Servicos.Paciente.Interfaces;
using ClinicasCRM.Core.Dtos.Paciente;
using ClinicasCRM.Core.Exceptions;
using ClinicasCRM.Core.Models.Paciente;
using Microsoft.EntityFrameworkCore;

namespace ClinicasCRM.Api.Servicos.Paciente;

public class HabitosMasculinosService : ServicoBase<HabitosMasculinos>, IHabitosMasculinosService
{
    private IMapper _mapper;

    public HabitosMasculinosService(AppDbContext context, IMapper mapper) : base(context)
    {
        _mapper = mapper;
    }

    public async Task<HabitosMasculinosDto> AtualizarAsync(long id, HabitosMasculinosDto dto)
    {
        var habitos = await ObterAsync(id, dto.UsuarioId);
        if (habitos is null)
            throw new NotFoundException("Hábitos não encontrados");
        _mapper.Map(dto, habitos);
        habitos = await AtualizarAsync(habitos);
        return _mapper.Map<HabitosMasculinosDto>(habitos);
    }

    public async Task<HabitosMasculinosDto> InserirAsync(HabitosMasculinosDto dto)
    {
        var habitos = new HabitosMasculinos();
        _mapper.Map(dto, habitos);
        habitos = await InserirAsync(habitos);
        return _mapper.Map<HabitosMasculinosDto>(habitos);
    }

    public Task<List<HabitosMasculinosDto>> ObterPorClienteAsync(long clienteId, string usuarioId)
    {
        var habitos = _context.HabitosMasculinos
        .AsNoTracking()
        .Where(x => x.ClienteId == clienteId
        && x.UsuarioId.Equals(usuarioId, StringComparison.InvariantCultureIgnoreCase));
        return _mapper.ProjectTo<HabitosMasculinosDto>(habitos).ToListAsync();
    }

    public async Task<HabitosMasculinosDto> ObterPorIdAsync(long id, string usuarioId)
    {
        var habitos = await ObterAsync(id, usuarioId);
        if (habitos is null)
            throw new NotFoundException("Hábitos não encontrados");
        return _mapper.Map<HabitosMasculinosDto>(habitos);
    }

    async Task<List<HabitosMasculinosDto>> IHabitosMasculinosService.TodosAsync(string usuarioId)
    {
        var habitos = _context.HabitosMasculinos
        .AsNoTracking()
        .Where(x => x.UsuarioId.Equals(usuarioId, StringComparison.InvariantCultureIgnoreCase));
        return _mapper.Map<List<HabitosMasculinosDto>>(await habitos.ToListAsync());
    }
}
