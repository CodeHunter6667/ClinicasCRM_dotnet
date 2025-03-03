using ClinicasCRM.Api.Data;
using ClinicasCRM.Core.Exceptions;
using ClinicasCRM.Core.Models.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using ClinicasCRM.Api.Services.Base.Interfaces;

namespace ClinicasCRM.Api.Services.Base;

public abstract class BaseService<T> : 
    IBaseService<T>
    where T : BaseEntity
{
    protected AppDbContext _context;
    public BaseService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<T>> GetAll(string userId)
        => await _context.Set<T>().AsNoTracking().Where(x => x.UserId.Equals(userId, StringComparison.InvariantCultureIgnoreCase)).ToListAsync();

    public async Task<T?> Get(Expression<Func<T, bool>> predicate)
    {
        var entity = await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(predicate);
        if (entity is null)
            throw new NotFoundException("Não encontrado nenhum registro com esses dados");
        return entity;
    }

    public async Task<T?> GetById(long id, string userId)
    {
        var entity = await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id && x.UserId.Equals(userId, StringComparison.InvariantCultureIgnoreCase));
        if (entity is null)
            throw new NotFoundException("Não encontrado nenhum registro com esses dados");
        return entity;
    }

    public async Task InsertOrUpdate(T entity, string username)
    {
        if (entity is null)
            throw new ArgumentNullException("Dados inválidos");

        if (entity.IsSaved)
            await Update(entity, username);
        else
            await Insert(entity, username);
    }

    public async Task<T> Update(T entity, string username)
    {
        if (entity is null)
            throw new ArgumentNullException("Dados inválidos");
        entity.UpdatedAt = DateTime.Now;
        entity.UpdatedBy = username;
        _context.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<T> Insert(T entity, string username)
    {
        if (entity is null)
            throw new ArgumentNullException("Dados inválidos");
        entity.CreatedAt = DateTime.Now;
        entity.CreatedBy = username;
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task Delete(long id, string userId)
    {
        var entity = await GetById(id, userId);
        if (entity is null)
            throw new NotFoundException("Não encontrado nenhum registro com esses dados");

        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }
}
