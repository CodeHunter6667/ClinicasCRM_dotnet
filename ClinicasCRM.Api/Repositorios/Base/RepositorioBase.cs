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

    public void Atualizar(T entidade)
    {
        _context.Set<T>().Update(entidade);
        _context.SaveChanges();
    }

    public void Deletar(T entidade)
    {
        _context.Set<T>().Remove(entidade);
        _context.SaveChanges();
    }

    public void Inserir(T entidade)
    {
        _context.Set<T>().Add(entidade);
        _context.SaveChanges();
    }

    public T? Obter(Expression<Func<T, bool>> predicado)
    {
        return _context.Set<T>().AsNoTracking().FirstOrDefault(predicado);
    }

    public T? Obter(long id)
    {
        return _context.Set<T>().AsNoTracking().FirstOrDefault(x => x.Id == id);
    }

    public IEnumerable<T> Todos()
    {
        return _context.Set<T>().AsNoTracking();
    }
}
