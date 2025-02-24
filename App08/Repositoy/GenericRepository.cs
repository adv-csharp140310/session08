
using App08.Model;

namespace App08.Repositoy;
public class GenericRepository
{
    //crud
    AppDbContext ctx = new AppDbContext();

    public void Add<T>(T model) where T : class
    {
        ctx.Add(model);
        ctx.SaveChanges();
    }

    public void Update<T>(T model) where T : class
    {
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        ctx.SaveChanges();
    }

    public void Delete<T>(T model) where T : class
    {
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        ctx.SaveChanges();
    }

    public T GetById<T>(int Id) where T : BaseEntity
    {
        return ctx.Set<T>().FirstOrDefault(x => x.Id == Id);
    }

    //leaky abstraction
    public IQueryable<T> Get<T>() where T : class
    {
        var ctx = new AppDbContext();
        return ctx.Set<T>().AsQueryable();
    }
}
