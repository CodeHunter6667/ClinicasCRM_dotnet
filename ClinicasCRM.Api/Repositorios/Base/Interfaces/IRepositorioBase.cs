using ClinicasCRM.Core.Models.Base;
using System.Linq.Expressions;

namespace ClinicasCRM.Api.Repositorios.Base.Interfaces;

public interface IRepositorioBase
{
}

public interface IRepositorioBase<T> : IRepositorioBase where T : EntidadeBase
{
    void Inserir(T entidade);
    void Atualizar(T entidade);
    void Deletar(T entidade);
    T? Obter(Expression<Func<T, bool>> predicado);
    T? Obter(long id);
    IEnumerable<T> Todos();
}