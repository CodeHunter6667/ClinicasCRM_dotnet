using AutoMapper;
using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Services.Base;
using ClinicasCRM.Api.Services.Consulation.Interfaces;
using ClinicasCRM.Core.Dtos.Consulation;
using ClinicasCRM.Core.Exceptions;
using ClinicasCRM.Core.Models.Consulation;
using Microsoft.EntityFrameworkCore;

namespace ClinicasCRM.Api.Services.Consulation;

public class FacialAnamnesisService : BaseService<FacialAnamnesis>, IFacialAnamnesisService
{
    private IMapper _mapper;
    public FacialAnamnesisService(AppDbContext context, IMapper mapper) : base(context)
    {
        _mapper = mapper;
    }

    public async Task<FacialAnamnesisDto> InsertAsync(FacialAnamnesisDto dto, string username, string userId)
    {
        var anamnese = new FacialAnamnesis();
        _mapper.Map(dto, anamnese);
        var newAnamnese = await Insert(anamnese, username, userId);
        return _mapper.Map<FacialAnamnesisDto>(newAnamnese);
    }

    public async Task<List<FacialAnamnesisDto>> GetAllAsync(string userId)
    {
        var anamneses = _context
            .FacialAnamnesis
            .Where(x => x.UserId.Equals(userId, StringComparison.InvariantCultureIgnoreCase));
        return _mapper.Map<List<FacialAnamnesisDto>>( await anamneses.ToListAsync());
    }

    public async Task<List<FacialAnamnesisDto>> GetAllByClientAsync(long clientId, string userId)
    {
        var anamneses = _context
            .FacialAnamnesis
            .Where(x =>
            x.ClientId == clientId
            && x.UserId.Equals(userId, StringComparison.InvariantCultureIgnoreCase));
        
        return _mapper.Map<List<FacialAnamnesisDto>>(await anamneses.ToListAsync());
    }

    public async Task<FacialAnamnesisDto> GetByIdAsync(long id, string userId)
    {
        var anamnese = await GetById(id, userId);
        if (anamnese is null)
            throw new NotFoundException("Anamnese facial não encontrada");
        return _mapper.Map<FacialAnamnesisDto>(anamnese);
    }

    public async Task<FacialAnamnesisDto> UpdateAsync(long id, FacialAnamnesisDto dto, string username, string userId)
    {
        var anamnese = await GetById(id, userId);
        if (anamnese is null)
            throw new NotFoundException("Anamnese facial não encontrada");
        _mapper.Map(dto, anamnese);
        anamnese = await Update(anamnese, username, userId);
        return _mapper.Map<FacialAnamnesisDto>(anamnese);
    }
}
