using ClinicasCRM.Core.Models.Base;
using System.Linq.Expressions;

namespace ClinicasCRM.Api.Services.Base.Interfaces;

public interface IBaseService { }

public interface IBaseService<T> where T : BaseEntity
{
    Task<IEnumerable<T>> GetAll(string userId);
    Task<T?> Get(Expression<Func<T, bool>> predicate);
    Task<T?> GetById(long id, string userId);
    Task InsertOrUpdate(T entity, string username);
    Task<T> Update(T entity, string username);
    Task<T> Insert(T entidade, string username);
    Task Delete(long id, string userId);
}
