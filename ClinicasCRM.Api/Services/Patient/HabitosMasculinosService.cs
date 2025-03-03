using AutoMapper;
using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Servicos.Base;
using ClinicasCRM.Api.Servicos.Paciente.Interfaces;
using ClinicasCRM.Core.Dtos.Paciente;
using ClinicasCRM.Core.Exceptions;
using ClinicasCRM.Core.Models.Paciente;
using Microsoft.EntityFrameworkCore;

namespace ClinicasCRM.Api.Servicos.Paciente;

public class HabitosMasculinosService : BaseService<MaleHabits>, IHabitosMasculinosService
{
    private IMapper _mapper;

    public HabitosMasculinosService(AppDbContext context, IMapper mapper) : base(context)
    {
        _mapper = mapper;
    }

    public async Task<MaleHabitsDto> AtualizarAsync(long id, MaleHabitsDto dto)
    {
        var habitos = await ObterAsync(id, dto.UsuarioId);
        if (habitos is null)
            throw new NotFoundException("Hábitos não encontrados");
        _mapper.Map(dto, habitos);
        habitos = await AtualizarAsync(habitos);
        return _mapper.Map<MaleHabitsDto>(habitos);
    }

    public async Task<MaleHabitsDto> InserirAsync(MaleHabitsDto dto)
    {
        var habitos = new MaleHabits();
        _mapper.Map(dto, habitos);
        habitos = await InserirAsync(habitos);
        return _mapper.Map<MaleHabitsDto>(habitos);
    }

    public Task<List<MaleHabitsDto>> ObterPorClienteAsync(long clienteId, string usuarioId)
    {
        var habitos = _context.MaleHabits
        .AsNoTracking()
        .Where(x => x.ClienteId == clienteId
        && x.UsuarioId.Equals(usuarioId, StringComparison.InvariantCultureIgnoreCase));
        return _mapper.ProjectTo<MaleHabitsDto>(habitos).ToListAsync();
    }

    public async Task<MaleHabitsDto> ObterPorIdAsync(long id, string usuarioId)
    {
        var habitos = await ObterAsync(id, usuarioId);
        if (habitos is null)
            throw new NotFoundException("Hábitos não encontrados");
        return _mapper.Map<MaleHabitsDto>(habitos);
    }

    async Task<List<MaleHabitsDto>> IHabitosMasculinosService.TodosAsync(string usuarioId)
    {
        var habitos = _context.MaleHabits
        .AsNoTracking()
        .Where(x => x.UsuarioId.Equals(usuarioId, StringComparison.InvariantCultureIgnoreCase));
        return _mapper.Map<List<MaleHabitsDto>>(await habitos.ToListAsync());
    }
}
