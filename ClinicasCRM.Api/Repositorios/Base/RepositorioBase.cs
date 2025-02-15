using ClinicasCRM.Api.Data;
using ClinicasCRM.Api.Repositorios.Base.Interfaces;
using ClinicasCRM.Core.Models.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ClinicasCRM.Api.Repositorios.Base;

public class RepositorioBase<T> : IRepositorioBase<T> where T : EntidadeBase
{
    protected AppDbContext _context;

    public RepositorioBase(AppDbContext context)
    {
        _context = context;
    }

    public async Task<T> AtualizarAsync(T entidade)
    {
        var entidadeSalva = _context.Set<T>().Update(entidade);
        await _context.SaveChangesAsync();
        return entidadeSalva.Entity;
    }

    public async Task DeletarAsync(T entidade)
    {
        _context.Set<T>().Remove(entidade);
        await _context.SaveChangesAsync();
    }

    public async Task<T> InserirAsync(T entidade)
    {
        var entidadeSalva = await _context.Set<T>().AddAsync(entidade);
        await _context.SaveChangesAsync();
        return entidadeSalva.Entity;
    }

    public async Task<T?> ObterAsync(Expression<Func<T, bool>> predicado)
    {
        return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(predicado);
    }

    public async Task<T?> ObterAsync(long id)
    {
        return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<IEnumerable<T>> TodosAsync()
    {
        return await _context.Set<T>().AsNoTracking().ToListAsync();
    }
}
