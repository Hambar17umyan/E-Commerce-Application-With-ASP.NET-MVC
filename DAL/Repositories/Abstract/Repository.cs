using DAL.Db;
using DAL.Entities.Abstract;
using Domain.ResultPattern;
using FluentResults;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Abstract;

public class Repository<TEntity> where TEntity : class, IDbEntity
{
    private AppDbContext _context;
    public Repository(AppDbContext context)
    {
        this._context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<Result<TEntity>> GetByIdAsync(int id)
    {
        var res = await this._context.Set<TEntity>().FindAsync(id);
        if (res == null)
        {
            return Result.Fail(ApplicationError.NotFound($"{nameof(TEntity)} not found!"));
        }

        return Result.Ok(res);
    }

    public async Task<Result<List<TEntity>>> GetAllAsync()
    {
        var res = await this._context.Set<TEntity>().ToListAsync();
        if (res == null)
        {
            return Result.Fail(ApplicationError.NotFound($"{nameof(TEntity)} not found!"));
        }

        return Result.Ok(res);
    }

    public async Task<Result> Add(TEntity entity)
    {
        if (entity == null)
        {
            return Result.Fail(ApplicationError.BadRequest("Entity is null."));
        }

        await this._context.Set<TEntity>().AddAsync(entity);
        await this._context.SaveChangesAsync();
        return Result.Ok();
    }


}
