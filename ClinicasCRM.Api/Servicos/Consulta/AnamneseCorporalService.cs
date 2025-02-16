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
    private readonly IMapper _mapper;

    public AnamneseCorporalService(IMapper mapper, AppDbContext context) : base(context)
    {
        _mapper = mapper;
    }

    public async Task<AnamneseCorporalDto> AtualizarAsync(long id, AnamneseCorporalDto anamneseCorporalDto)
    {
        var anamneseCorporal = await ObterAsync(id, anamneseCorporalDto.UsuarioId);
        if (anamneseCorporal is null)
            throw new NotFoundException("Anamnese não encontrada");
        _mapper.Map(anamneseCorporalDto, anamneseCorporal);
        anamneseCorporal = await AtualizarAsync(anamneseCorporal);
        return _mapper.Map<AnamneseCorporalDto>(anamneseCorporal);
    }

    public async Task<AnamneseCorporalDto> InserirAsync(AnamneseCorporalDto anamneseCorporalDto)
    {
        var anamneseCorporal = new AnamneseCorporal();
        _mapper.Map(anamneseCorporalDto, anamneseCorporal);
        anamneseCorporal = await InserirAsync(anamneseCorporal);
        return _mapper.Map<AnamneseCorporalDto>(anamneseCorporal);
    }

    public async Task<AnamneseCorporalDto> ObterPorId(long id, string usuarioId)
    {
        var anamnese = await ObterAsync(id, usuarioId);
        if(anamnese is null)
            throw new NotFoundException("Anamnese não encontrada");

        return _mapper.Map<AnamneseCorporalDto>(anamnese);
    }

    public async Task<List<AnamneseCorporalDto>> TodosPorCliente(long clienteId, string usuarioId)
    {
        var anamneses = _context
            .AnamnesesCorporais
            .Where(x => 
            x.ClienteId == clienteId
            && x.UsuarioId.Equals(usuarioId, StringComparison.InvariantCultureIgnoreCase));
        return _mapper.Map<List<AnamneseCorporalDto>>( await anamneses.ToListAsync());
    }
}
