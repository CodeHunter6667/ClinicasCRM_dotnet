using AutoMapper;
using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Services.Appointment.Interfaces;
using ClinicasCRM.Api.Services.Base;
using ClinicasCRM.Core.Dtos.Appointment;
using ClinicasCRM.Core.Enums;
using ClinicasCRM.Core.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace ClinicasCRM.Api.Services.Appointment;

public class AppointmentService : BaseService<ClinicasCRM.Core.Models.Appointment.Appointment>, IAppointmentService
{
    private readonly IMapper _mapper;

    public AppointmentService(IMapper mapper, AppDbContext context) : base(context)
    {
        _mapper = mapper;
    }
    
    public async Task<List<AppointmentDto>> GetAllByClientAsync(long clientId, string userId, int pageSize, int pageNumber)
    {
        var appointments = await _context.Appoitments
                                        .AsNoTracking()
                                        .Where(a => a.ClientId == clientId && a.UserId.Equals(userId, StringComparison.InvariantCultureIgnoreCase))
                                        .Skip((pageNumber - 1) * pageSize)
                                        .Take(pageSize)
                                        .OrderBy(a => a.AppoitmentDate)
                                        .ToListAsync();
        return _mapper.Map<List<AppointmentDto>>(appointments);
    }

    public async Task<List<AppointmentDto>> GetAllAsync(string userId, int pageSize, int pageNumber)
    {
        var appointments = await GetAll(userId);
        return _mapper.Map<List<AppointmentDto>>(appointments
                                                .Skip((pageNumber - 1) * pageSize)
                                                .Take(pageSize)
                                                .ToList());
    }

    public async Task<List<AppointmentDto>> GetAllByDateAsync(DateTime date, string userId, int pageSize, int pageNumber)
    {
        var appointments = await _context
            .Appoitments
            .AsNoTracking()
            .Where(a =>
                a.AppoitmentDate.Date == date.Date
                && a.UserId.Equals(userId, StringComparison.InvariantCultureIgnoreCase)
                && a.AppoitmentStatus == EStatusAtendimento.Finalizado)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize).ToListAsync();
        return _mapper.Map<List<AppointmentDto>>(appointments);
    }

    public async Task<List<AppointmentDto>> GetAllByDateAsync(DateTime initialDate, DateTime endDate, string userId)
    {
        var appointments = await _context
            .Appoitments
            .AsNoTracking()
            .Where(a =>
            a.AppoitmentDate.Date >= initialDate.Date
            && a.AppoitmentDate.Date <= endDate.Date
            && a.UserId.Equals(userId, StringComparison.InvariantCultureIgnoreCase))
            .ToListAsync();
        return _mapper.Map<List<AppointmentDto>>(appointments);
    }

    public async Task<AppointmentDto> GetByIdAsync(long id, string userId)
    {
        var appointment = await GetById(id, userId);
        return _mapper.Map<AppointmentDto>(appointment);
    }

    public async Task<AppointmentDto> InsertAsync(AppointmentDto dto, string username, string userId)
    {
        var existAppointment = await GetAll(dto.UserId);
        if (existAppointment.Any(a =>
        a.AppoitmentTime.Hours == dto.AppoitmentTime.Hours
        && a.AppoitmentTime.Minutes == dto.AppoitmentTime.Minutes))
            throw new BadRequestException("Já existe um agendamento para esse dia");
        
        var appointment = _mapper.Map<ClinicasCRM.Core.Models.Appointment.Appointment>(dto);
        appointment = await Insert(appointment, username, userId);
        return _mapper.Map<AppointmentDto>(appointment);
    }

    public async Task<AppointmentDto> UpdateAsync(long id, AppointmentDto dto, string username, string userId)
    {
        var existAppointment = await GetById(id, dto.UserId);
        if (existAppointment is null)
            throw new NotFoundException("Agendamento não econtrado");

        var updatedAppointment = _mapper.Map(dto, existAppointment);
        await Update(updatedAppointment, username, userId);
        
        return _mapper.Map<AppointmentDto>(updatedAppointment);
    }
}
