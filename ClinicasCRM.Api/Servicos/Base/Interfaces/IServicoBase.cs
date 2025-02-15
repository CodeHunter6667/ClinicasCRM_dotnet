using ClinicasCRM.Core.Models.Base;
using System.Linq.Expressions;

namespace ClinicasCRM.Api.Servicos.Base.Interfaces;

public interface IServicoBase { }

public interface IServicoBase<T> where T : EntidadeBase
{
    Task<IEnumerable<T>> TodosAsync();
    Task<T?> ObterAsync(Expression<Func<T, bool>> predicado);
    Task<T?> ObterAsync(long id);
    Task InserirOuAtualizarAsync(T entidade);
    Task<T> AtualizarAsync(T entidade);
    Task<T> InserirAsync(T entidade);
    Task DeletarAsync(long id);
}
