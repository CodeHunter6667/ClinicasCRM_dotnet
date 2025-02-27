﻿using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Servicos.Base.Interfaces;
using ClinicasCRM.Core.Exceptions;
using ClinicasCRM.Core.Models.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ClinicasCRM.Api.Servicos.Base;

public abstract class ServicoBase<T> : 
    IServicoBase<T>
    where T : EntidadeBase
{
    protected AppDbContext _context;
    public ServicoBase(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<T>> TodosAsync(string usuarioId)
        => await _context.Set<T>().AsNoTracking().Where(x => x.UsuarioId.Equals(usuarioId, StringComparison.InvariantCultureIgnoreCase)).ToListAsync();

    public async Task<T?> ObterAsync(Expression<Func<T, bool>> predicado)
    {
        var entidade = await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(predicado);
        if (entidade is null)
            throw new NotFoundException("Não encontrado nenhum registro com esses dados");
        return entidade;
    }

    public async Task<T?> ObterAsync(long id, string usuarioId)
    {
        var entidade = await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id && x.UsuarioId.Equals(usuarioId, StringComparison.InvariantCultureIgnoreCase));
        if (entidade is null)
            throw new NotFoundException("Não encontrado nenhum registro com esses dados");
        return entidade;
    }

    public async Task InserirOuAtualizarAsync(T entidade)
    {
        if (entidade is null)
            throw new ArgumentNullException("Dados inválidos");

        if (entidade.EstaSalva)
            await AtualizarAsync(entidade);
        else
            await InserirAsync(entidade);
    }

    public async Task<T> AtualizarAsync(T entidade)
    {
        if (entidade is null)
            throw new ArgumentNullException("Dados inválidos");
        entidade.DataAlteracao = DateTime.Now;
        _context.Update(entidade);
        await _context.SaveChangesAsync();
        return entidade;
    }

    public async Task<T> InserirAsync(T entidade)
    {
        if (entidade is null)
            throw new ArgumentNullException("Dados inválidos");
        entidade.DataCriacao = DateTime.Now;
        await _context.Set<T>().AddAsync(entidade);
        await _context.SaveChangesAsync();
        return entidade;
    }

    public async Task DeletarAsync(long id, string usuarioId)
    {
        var entidade = await ObterAsync(id, usuarioId);
        if (entidade is null)
            throw new NotFoundException("Não encontrado nenhum registro com esses dados");

        _context.Set<T>().Remove(entidade);
        await _context.SaveChangesAsync();
    }
}
