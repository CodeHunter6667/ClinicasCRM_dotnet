using AutoMapper;
using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Services.Base;
using ClinicasCRM.Api.Services.Patient.Interfaces;
using ClinicasCRM.Core.Dtos.Patient;
using ClinicasCRM.Core.Exceptions;
using ClinicasCRM.Core.Models.Patient;
using Microsoft.EntityFrameworkCore;

namespace ClinicasCRM.Api.Services.Patient;

public class PatientHistoryService : BaseService<PatientHistory>, IPatientHistoryService
{
    private IMapper _mapper;
    public PatientHistoryService(AppDbContext context, IMapper mapper) : base(context)
    {
        _mapper = mapper;
    }

    public async Task<PatientHistoryDto> UpdateAsync(long id, PatientHistoryDto dto, string username, string userId)
    {
        var historico = await GetById(id, userId);
        if (historico is null)
            throw new NotFoundException("Histórico não encontrado.");
        historico = _mapper.Map(dto, historico);
        historico = await Update(historico, username, userId);
        return _mapper.Map<PatientHistoryDto>(historico);
    }

    public async Task<PatientHistoryDto> InsertAsync(PatientHistoryDto dto, string username, string userId)
    {
        var historico = new PatientHistory();
        _mapper.Map(dto, historico);
        historico = await Insert(historico, username, userId);
        return _mapper.Map<PatientHistoryDto>(historico);
    }

    public async Task<List<PatientHistoryDto>> GetByClientAsync(long clienteId, string usuarioId)
    {
        var historicos = await _context.PatientHistories
        .AsNoTracking()
        .Where(h =>
        h.ClientId == clienteId
        && h.UserId == usuarioId)
        .ToListAsync();
        return _mapper.Map<List<PatientHistoryDto>>(historicos);
    }

    public async Task<PatientHistoryDto> GetByIdAsync(long id, string usuarioId)
    {
        var historico = await GetById(id, usuarioId);
        if (historico is null)
            throw new NotFoundException("Histórico não encontrado");
        return _mapper.Map<PatientHistoryDto>(historico);
    }

    public async Task<List<PatientHistoryDto>> GetAllAsync(string usuarioId)
    {
        var historicos = await _context.PatientHistories
        .AsNoTracking()
        .Where(x =>
        x.UserId.Equals(usuarioId, StringComparison.InvariantCultureIgnoreCase)).ToListAsync();
        return _mapper.Map<List<PatientHistoryDto>>(historicos);
    }
}
