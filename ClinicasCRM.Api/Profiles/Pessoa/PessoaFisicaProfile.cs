using AutoMapper;
using ClinicasCRM.Core.Dtos.Pessoa;
using ClinicasCRM.Core.Models.Pessoa;

namespace ClinicasCRM.Api.Profiles.Pessoa;

public class PessoaFisicaProfile : Profile
{
    public PessoaFisicaProfile()
    {
        CreateMap<PessoaFisica, PessoaFisicaDto>().ReverseMap();
    }
}
