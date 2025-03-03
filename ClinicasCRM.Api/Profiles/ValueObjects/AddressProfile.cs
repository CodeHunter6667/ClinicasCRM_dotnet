using AutoMapper;
using ClinicasCRM.Core.Dtos.ValueObjects;
using ClinicasCRM.Core.ValueObjects;

namespace ClinicasCRM.Api.Profiles.ValueObjects;

public class AddressProfile : Profile
{
    public AddressProfile()
    {
        CreateMap<Address, AddressDto>().ReverseMap();
    }
}
