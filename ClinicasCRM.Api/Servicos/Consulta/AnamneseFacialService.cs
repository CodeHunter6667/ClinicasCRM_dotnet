using AutoMapper;
using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Servicos.Base;
using ClinicasCRM.Api.Servicos.Consulta.Interfaces;
using ClinicasCRM.Core.Dtos.Consulta;
using ClinicasCRM.Core.Exceptions;
using ClinicasCRM.Core.Models.Consulta;
using Microsoft.EntityFrameworkCore;

namespace ClinicasCRM.Api.Servicos.Consulta;

public class AnamneseFacialService : ServicoBase<AnamneseFacial>, IAnamneseFacialService
{
    private IMapper _mapper;
    public AnamneseFacialService(AppDbContext context, IMapper mapper) : base(context)
    {
        _mapper = mapper;
    }

    public async Task<AnamneseFacialDto> AtualizarAsync(long id, AnamneseFacialDto dto)
    {
        var anamneseFacial = await ObterAsync(id, dto.UsuarioId);
        if (anamneseFacial is null)
            throw new NotFoundException("Anamnese facial não encontrada");
        _mapper.Map(dto, anamneseFacial);
        anamneseFacial = await AtualizarAsync(anamneseFacial);
        return _mapper.Map<AnamneseFacialDto>(anamneseFacial);
    }

    public async Task<AnamneseFacialDto> InserirAsync(AnamneseFacialDto dto)
    {
        var anamneseFacial = new AnamneseFacial();
        _mapper.Map(dto, anamneseFacial);
        anamneseFacial = await InserirAsync(anamneseFacial);
        return _mapper.Map<AnamneseFacialDto>(anamneseFacial);
    }

    public async Task<List<AnamneseFacialDto>> TodosPorClienteAsync(long clienteId, string usuarioId)
    {
        var anamneses = _context
            .AnamnesesFaciais
            .Where(x =>
            x.ClienteId == clienteId
            && x.UsuarioId.Equals(usuarioId, StringComparison.InvariantCultureIgnoreCase));
        
        return _mapper.Map<List<AnamneseFacialDto>>(await anamneses.ToListAsync());
    }

    public async Task<AnamneseFacialDto> ObterPorIdAsync(long id, string usuarioId)
    {
        var anamneseFacial = await ObterAsync(id, usuarioId);
        if (anamneseFacial is null)
            throw new NotFoundException("Anamnese facial não encontrada");
        return _mapper.Map<AnamneseFacialDto>(anamneseFacial);
    }

    Task<List<AnamneseFacialDto>> IAnamneseFacialService.TodosAsync(string usuarioId)
    {
        var anamneses = _context
            .AnamnesesFaciais
            .Where(x => x.UsuarioId.Equals(usuarioId, StringComparison.InvariantCultureIgnoreCase));
        return _mapper.ProjectTo<AnamneseFacialDto>(anamneses).ToListAsync();
    }
}
