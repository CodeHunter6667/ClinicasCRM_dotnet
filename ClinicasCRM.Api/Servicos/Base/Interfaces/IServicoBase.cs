using ClinicasCRM.Core.Models.Base;
using System.Linq.Expressions;

namespace ClinicasCRM.Api.Servicos.Base.Interfaces;

public interface IServicoBase { }

public interface IServicoBase<T> where T : EntidadeBase
{
    IEnumerable<T> Todos();
    T? Obter(Expression<Func<T, bool>> predicado);
    T? Obter(long id);
    void InserirOuAtualizar(T entidade);
    void Atualizar(T entidade);
    void Inserir(T entidade);
    void Deletar(long id);
}
