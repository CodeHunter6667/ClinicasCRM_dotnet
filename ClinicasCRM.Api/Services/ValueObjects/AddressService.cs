using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Services.Base;
using ClinicasCRM.Api.Services.ValueObjects.Interfaces;
using ClinicasCRM.Core.ValueObjects;

namespace ClinicasCRM.Api.Services.ValueObjects;

public class AddressService : BaseService<Address>, IAddressService
{
    public AddressService(AppDbContext context) : base(context)
    {
        
    }
}
