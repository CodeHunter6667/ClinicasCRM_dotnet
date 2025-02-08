using AutoMapper;
using ClinicasCRM.Core.Dtos.Pessoa;
using ClinicasCRM.Core.Models.Pessoa;

namespace ClinicasCRM.Api.Profiles.Pessoa;

public class PessoaJuridicaProfile : Profile
{
    public PessoaJuridicaProfile()
    {
        CreateMap<PessoaJuridica, PessoaJuridicaDto>().ReverseMap();
    }
}
