using AutoMapper;
using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Services.Base;
using ClinicasCRM.Api.Services.Patient.Interfaces;
using ClinicasCRM.Core.Dtos.Patient;
using ClinicasCRM.Core.Exceptions;
using ClinicasCRM.Core.Models.Patient;
using Microsoft.EntityFrameworkCore;

namespace ClinicasCRM.Api.Services.Patient;

public class FemaleHabitsService : BaseService<FemaleHabits>, IFemaleHabitsService
{
    private IMapper _mapper;
    public FemaleHabitsService(AppDbContext context, IMapper mapper) : base(context)
    {
        _mapper = mapper;
    }

    public async Task<FemaleHabitsDto> UpdateAsync(long id, FemaleHabitsDto dto, string username, string userId)
    {
        var habits = await GetById(id, userId);
        if (habits is null)
            throw new NotFoundException("Hábitos femininos não encontrados");
        _mapper.Map(dto, habits);
        habits = await Update(habits, username, userId);
        return _mapper.Map<FemaleHabitsDto>(habits);
    }

    public async Task<FemaleHabitsDto> InsertAsync(FemaleHabitsDto dto, string username, string userId)
    {
        var habits = new FemaleHabits();
        _mapper.Map(dto, habits);
        habits = await Insert(habits, username, userId);
        return _mapper.Map<FemaleHabitsDto>(habits);
    }

    public async Task<List<FemaleHabitsDto>> GetByClientAsync(long clientId, string userId)
    {
        var habits = await _context.FemaleHabits
        .AsNoTracking()
        .Where(x =>
        x.ClientId == clientId
        && x.UserId.Equals(userId, StringComparison.InvariantCultureIgnoreCase))
        .ToListAsync();
        return _mapper.Map<List<FemaleHabitsDto>>(habits);
    }

    public async Task<FemaleHabitsDto> GetByIdAsync(long id, string userId)
    {
        var habits = await GetById(id, userId);
        if (habits is null)
            throw new NotFoundException("Hábitos femininos não encontrados");
        return _mapper.Map<FemaleHabitsDto>(habits);
    }

    public async Task<List<FemaleHabitsDto>> GetAllAsync(string userId)
    {
        var habits = await _context.FemaleHabits
        .AsNoTracking()
        .Where(x =>
        x.UserId.Equals(userId, StringComparison.InvariantCultureIgnoreCase))
        .ToListAsync();
        return _mapper.Map<List<FemaleHabitsDto>>(habits);
    }
}
