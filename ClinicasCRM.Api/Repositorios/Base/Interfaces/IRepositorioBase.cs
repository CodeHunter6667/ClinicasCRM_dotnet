using ClinicasCRM.Core.Models.Base;
using System.Linq.Expressions;

namespace ClinicasCRM.Api.Repositorios.Base.Interfaces;

public interface IRepositorioBase
{
}

public interface IRepositorioBase<T> : IRepositorioBase where T : EntidadeBase
{
    Task<T> InserirAsync(T entidade);
    Task<T> AtualizarAsync(T entidade);
    Task DeletarAsync(T entidade);
    Task<T?> ObterAsync(Expression<Func<T, bool>> predicado);
    Task<T?> ObterAsync(long id);
    Task<IEnumerable<T>> TodosAsync();
}