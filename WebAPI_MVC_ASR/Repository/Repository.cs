using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebAPI_MVC_ASR.Datos;
using WebAPI_MVC_ASR.Repository.IRepository;

namespace WebAPI_MVC_ASR.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();

            context.Database.EnsureCreated();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null)
        {
            IQueryable<T> queryable = dbSet;

            if (filter != null)
            {
                queryable = queryable.Where(filter);
            }

            return await queryable.ToListAsync();
        }

        public async Task<T?> GetAsync(Expression<Func<T, bool>>? filter = null)
        {
            IQueryable<T> queryable = dbSet;

            if (filter != null){
                queryable = queryable.Where(filter);
            }

            return await queryable.FirstOrDefaultAsync();
        }
    }
}
