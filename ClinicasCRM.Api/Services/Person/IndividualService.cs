using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Services.Base;
using ClinicasCRM.Api.Services.Person.Interfaces;
using ClinicasCRM.Core.Models.Person;

namespace ClinicasCRM.Api.Services.Person;

public class IndividualService : BaseService<Individual>, IIndividualService
{
    public IndividualService(AppDbContext context) : base(context)
    {
        
    }
}
