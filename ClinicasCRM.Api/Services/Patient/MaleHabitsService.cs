using AutoMapper;
using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Services.Base;
using ClinicasCRM.Api.Services.Patient.Interfaces;
using ClinicasCRM.Core.Dtos.Patient;
using ClinicasCRM.Core.Exceptions;
using ClinicasCRM.Core.Models.Patient;
using Microsoft.EntityFrameworkCore;

namespace ClinicasCRM.Api.Services.Patient;

public class MaleHabitsService : BaseService<MaleHabits>, IMaleHabitsService
{
    private IMapper _mapper;

    public MaleHabitsService(AppDbContext context, IMapper mapper) : base(context)
    {
        _mapper = mapper;
    }

    public async Task<MaleHabitsDto> UpdateAsync(long id, MaleHabitsDto dto, string username, string userId)
    {
        var habits = await GetById(id, userId);
        if (habits is null)
            throw new NotFoundException("Hábitos não encontrados");
        _mapper.Map(dto, habits);
        habits = await Update(habits, username, userId);
        return _mapper.Map<MaleHabitsDto>(habits);
    }

    public async Task<MaleHabitsDto> InsertAsync(MaleHabitsDto dto, string username, string userId)
    {
        var habits = new MaleHabits();
        _mapper.Map(dto, habits);
        habits = await Insert(habits, username, userId);
        return _mapper.Map<MaleHabitsDto>(habits);
    }

    public async Task<List<MaleHabitsDto>> GetByClientAsync(long clientId, string userId)
    {
        var habits = await _context.MaleHabits
        .AsNoTracking()
        .Where(x => x.ClientId == clientId
        && x.UserId.Equals(userId, StringComparison.InvariantCultureIgnoreCase))
        .ToListAsync();
        return _mapper.Map<List<MaleHabitsDto>>(habits);
    }

    public async Task<MaleHabitsDto> GetByIdAsync(long id, string userId)
    {
        var habits = await GetById(id, userId);
        if (habits is null)
            throw new NotFoundException("Hábitos não encontrados");
        return _mapper.Map<MaleHabitsDto>(habits);
    }

    public async Task<List<MaleHabitsDto>> GetAllAsync(string userId)
    {
        var habits = await _context.MaleHabits
        .AsNoTracking()
        .Where(x => x.UserId.Equals(userId, StringComparison.InvariantCultureIgnoreCase))
        .ToListAsync();
        return _mapper.Map<List<MaleHabitsDto>>(habits);
    }
}
