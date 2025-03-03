using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Services.Base;
using ClinicasCRM.Api.Services.Person.Interfaces;
using ClinicasCRM.Core.Models.Person;

namespace ClinicasCRM.Api.Services.Person
{
    public class ProfessionalService : BaseService<Professional>, IProfessionalService
    {
        public ProfessionalService(AppDbContext context) : base(context)
        {
        }
    }
}
