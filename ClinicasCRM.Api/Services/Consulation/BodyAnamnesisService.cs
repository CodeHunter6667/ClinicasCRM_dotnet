using AutoMapper;
using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Services.Base;
using ClinicasCRM.Api.Services.Consulation.Interfaces;
using ClinicasCRM.Core.Dtos.Consulation;
using ClinicasCRM.Core.Exceptions;
using ClinicasCRM.Core.Models.Consulation;
using Microsoft.EntityFrameworkCore;

namespace ClinicasCRM.Api.Services.Consulation;

public class BodyAnamnesisService : BaseService<BodyAnamnesis>, IBodyAnamnesisService
{
    private readonly IMapper _mapper;

    public BodyAnamnesisService(IMapper mapper, AppDbContext context) : base(context)
    {
        _mapper = mapper;
    }
    
    public async Task<List<BodyAnamnesisDto>> GetAllByClientAsync(long clientId, string userId)
    {
        var anamnesis = await _context
            .BodyAnamnesis
            .Where(x =>
                x.ClientId == clientId
                && x.UserId.Equals(userId, StringComparison.InvariantCultureIgnoreCase))
            .ToListAsync();
        
        return _mapper.Map<List<BodyAnamnesisDto>>(anamnesis);
    }

    public async Task<List<BodyAnamnesisDto>> GetAllAsync(string userId)
    {
        var anamnesis = await GetAll(userId);

        return _mapper.Map<List<BodyAnamnesisDto>>(anamnesis);
    }

    public async Task<BodyAnamnesisDto> GetByIdAsync(long id, string userId)
    {
        var anamnese = await GetById(id, userId);
        if(anamnese is null)
            throw new NotFoundException("Anamnese não encontrada");
        
        return _mapper.Map<BodyAnamnesisDto>(anamnese);
    }

    public async Task<BodyAnamnesisDto> InsertAsync(BodyAnamnesisDto dto, string username, string userId)
    {
        var anamnese = new BodyAnamnesis();
        _mapper.Map(dto, anamnese);
        var newAnamnese = await Insert(anamnese, username, userId);
        return _mapper.Map<BodyAnamnesisDto>(newAnamnese);
    }

    public async Task<BodyAnamnesisDto> UpdateAsync(long id, BodyAnamnesisDto dto, string username, string userId)
    {
        var anamnese = await GetById(id, userId);
        if (anamnese is null)
            throw new NotFoundException("Anamnese não encontrada");
        _mapper.Map(dto, anamnese);
        var updatedAnamnese = await Update(anamnese, username, userId);
        return _mapper.Map<BodyAnamnesisDto>(updatedAnamnese);
    }
}
