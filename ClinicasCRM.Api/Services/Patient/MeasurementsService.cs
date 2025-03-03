using AutoMapper;
using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Services.Base;
using ClinicasCRM.Api.Services.Patient.Interfaces;
using ClinicasCRM.Core.Dtos.Patient;
using ClinicasCRM.Core.Exceptions;
using ClinicasCRM.Core.Models.Patient;
using Microsoft.EntityFrameworkCore;

namespace ClinicasCRM.Api.Services.Patient;

public class MeasurementsService : BaseService<Measurements>, IMeasurementsService
{
    private IMapper _mapper;
    public MeasurementsService(AppDbContext context, IMapper mapper) : base(context)
    {
        _mapper = mapper;
    }

    public async Task<List<MeasurementsDto>> GetAllAsync(string userId)
    {
        var measurements = await _context
            .Measurements
            .AsNoTracking()
            .Where(x => 
            x.UserId
            .Equals(userId, StringComparison.InvariantCultureIgnoreCase))
            .ToListAsync();
        return _mapper.Map<List<MeasurementsDto>>(measurements);
    }

    public async Task<List<MeasurementsDto>> GetByClientAsync(long clientId, string userId)
    {
        var measurement = await _context
            .Measurements
            .AsNoTracking()
            .Where(x => 
            x.ClientId == clientId 
            && x.UserId.Equals(userId, StringComparison.InvariantCultureIgnoreCase)).ToListAsync();
        return _mapper.Map<List<MeasurementsDto>>(measurement);
    }

    public async Task<MeasurementsDto> GetByIdAsync(long id, string userId)
    {
        var measurement = await GetByClientAsync(id, userId);
        if (measurement is null)
            throw new NotFoundException("Medidas não encontradas");
        return _mapper.Map<MeasurementsDto>(measurement);
    }

    public async Task<MeasurementsDto> InsertAsync(MeasurementsDto dto, string username, string userId)
    {
        var measurement = new Measurements();
        if (dto is null)
            throw new BadRequestException("Dados inválidos");
        _mapper.Map(dto, measurement);
        measurement = await Insert(measurement, username, userId);
        return _mapper.Map<MeasurementsDto>(measurement);
    }

    public async Task<MeasurementsDto> UpdateAsync(long id, MeasurementsDto dto, string username, string userId)
    {
        var measurements = await GetById(id, userId);
        if (measurements is null)
            throw new NotFoundException("Medidas não encontradas");
        _mapper.Map(dto, measurements);
        measurements = await Update(measurements, username, userId);
        return _mapper.Map<MeasurementsDto>(measurements);
    }
}
