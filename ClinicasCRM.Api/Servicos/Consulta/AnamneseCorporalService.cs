using AutoMapper;
using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Servicos.Base;
using ClinicasCRM.Api.Servicos.Consulta.Interfaces;
using ClinicasCRM.Core.Dtos.Consulta;
using ClinicasCRM.Core.Exceptions;
using ClinicasCRM.Core.Models.Consulta;
using Microsoft.EntityFrameworkCore;

namespace ClinicasCRM.Api.Servicos.Consulta;

public class AnamneseCorporalService : ServicoBase<AnamneseCorporal>, IAnamneseCorporalService
{
    private readonly IMapper mapper;

    public AnamneseCorporalService(IMapper _mapper, AppDbContext context) : base(context)
    {
        mapper = _mapper;
    }

    public async Task<AnamneseCorporalDto> ObterPorId(long id)
    {
        var anamnese = await ObterAsync(id);
        if(anamnese is null)
            throw new NotFoundException("Anamnese não encontrada");

        return mapper.Map<AnamneseCorporalDto>(anamnese);
    }

    public async Task<List<AnamneseCorporalDto>> TodosPorCliente(long clienteId)
    {
        var anamneses = _context.AnamnesesCorporais.Where(x => x.ClienteId == clienteId);
        return mapper.Map<List<AnamneseCorporalDto>>( await anamneses.ToListAsync());
    }
}
