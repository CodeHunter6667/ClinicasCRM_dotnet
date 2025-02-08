using AutoMapper;
using ClinicasCRM.Core.Dtos.ValueObjects;
using ClinicasCRM.Core.ValueObjects;

namespace ClinicasCRM.Api.Profiles.ValueObjects;

public class EnderecoProfile : Profile
{
    public EnderecoProfile()
    {
        CreateMap<Endereco, EnderecoDto>().ReverseMap();
    }
}
