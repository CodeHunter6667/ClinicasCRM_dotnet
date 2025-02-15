using AutoMapper;
using ClinicasCRM.Api.Repositorios.Consulta;
using ClinicasCRM.Api.Servicos.Base;
using ClinicasCRM.Api.Servicos.Consulta.Interfaces;
using ClinicasCRM.Core.Dtos.Consulta;
using ClinicasCRM.Core.Exceptions;
using ClinicasCRM.Core.Models.Consulta;

namespace ClinicasCRM.Api.Servicos.Consulta;

public class AnamneseCorporalService(IMapper _mapper) : ServicoBase<AnamneseCorporal, AnamneseCorporalRepositorio>, IAnamneseCorporalService
{
    
    public async Task<AnamneseCorporalDto> ObterPorId(long id)
    {
        var anamnese = await ObterAsync(id);
        if(anamnese is null)
            throw new NotFoundException("Anamnese não encontrada");

        return _mapper.Map<AnamneseCorporalDto>(anamnese);
    }

    public async Task<List<AnamneseCorporalDto>> TodosPorCliente(long clienteId)
    {
        var anamneses = await TodosAsync();
        anamneses = anamneses.Where(a => a.ClienteId == clienteId).ToList();
        return _mapper.Map<List<AnamneseCorporalDto>>(anamneses);
    }
}
