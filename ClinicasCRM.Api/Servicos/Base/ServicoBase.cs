using ClinicasCRM.Api.Repositorios.Base.Interfaces;
using ClinicasCRM.Api.Servicos.Base.Interfaces;
using ClinicasCRM.Core.Exceptions;
using ClinicasCRM.Core.Models.Base;
using Microsoft.EntityFrameworkCore;
using System;
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

    public IEnumerable<T> Todos()
        => _repositorio.Todos();

    public T? Obter(Expression<Func<T, bool>> predicado)
    {
        var entidade = _repositorio.Obter(predicado);
        if (entidade is null)
            throw new NotFoundException("Não encontrado nenhum registro com esses dados");
        return entidade;
    }

    public T? Obter(long id)
    {
        var entidade = _repositorio.Obter(id);
        if (entidade is null)
            throw new NotFoundException("Não encontrado nenhum registro com esses dados");
        return entidade;
    }

    public void InserirOuAtualizar(T entidade)
    {
        if (entidade is null)
            throw new ArgumentNullException("Dados inválidos");

        if (entidade.EstaSalva)
            _repositorio.Inserir(entidade);
        else
            _repositorio.Atualizar(entidade);
    }

    public void Atualizar(T entidade)
        => _repositorio.Atualizar(entidade);

    public void Inserir(T entidade)
        => _repositorio.Inserir(entidade);

    public void Deletar(long id)
    {
        var entidade = _repositorio.Obter(id);
        if (entidade is null)
            throw new NotFoundException("Não encontrado nenhum registro com esses dados");
        _repositorio.Deletar(entidade);
    }
}
