using ClinicasCRM.Api.Repositorios.Base.Interfaces;
using ClinicasCRM.Api.Servicos.Base.Interfaces;
using ClinicasCRM.Core.Exceptions;
using ClinicasCRM.Core.Models.Base;
using System.Linq.Expressions;

namespace ClinicasCRM.Api.Servicos.Base;

public abstract class ServicoBase<TRepositorio> :  IServicoBase
    where TRepositorio : class, IRepositorioBase
{
    protected TRepositorio _repositorio;

    protected ServicoBase() { }

    public ServicoBase(TRepositorio repositorio) => _repositorio = repositorio;
}

public abstract class ServicoBase<T, TRepositorio> : 
    ServicoBase<TRepositorio>,
    IServicoBase<T>
    where T : EntidadeBase
    where TRepositorio : class, IRepositorioBase<T>
{
    public ServicoBase(TRepositorio repositorio) : base(repositorio) { }

    public ServicoBase()
    {
        
    }

    public async Task<IEnumerable<T>> TodosAsync()
        => await _repositorio.TodosAsync();

    public async Task<T?> ObterAsync(Expression<Func<T, bool>> predicado)
    {
        var entidade = await _repositorio.ObterAsync(predicado);
        if (entidade is null)
            throw new NotFoundException("Não encontrado nenhum registro com esses dados");
        return entidade;
    }

    public async Task<T?> ObterAsync(long id)
    {
        var entidade = await _repositorio.ObterAsync(id);
        if (entidade is null)
            throw new NotFoundException("Não encontrado nenhum registro com esses dados");
        return entidade;
    }

    public async Task InserirOuAtualizarAsync(T entidade)
    {
        if (entidade is null)
            throw new ArgumentNullException("Dados inválidos");

        if (entidade.EstaSalva)
            await _repositorio.InserirAsync(entidade);
        else
            await _repositorio.AtualizarAsync(entidade);
    }

    public async Task<T> AtualizarAsync(T entidade)
        => await _repositorio.AtualizarAsync(entidade);

    public async Task<T> InserirAsync(T entidade)
        => await _repositorio.InserirAsync(entidade);

    public async Task DeletarAsync(long id)
    {
        var entidade = await _repositorio.ObterAsync(id);
        if (entidade is null)
            throw new NotFoundException("Não encontrado nenhum registro com esses dados");
        await _repositorio.DeletarAsync(entidade);
    }
}
