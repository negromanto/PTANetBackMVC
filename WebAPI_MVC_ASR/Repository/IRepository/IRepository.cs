using System.Linq.Expressions;

namespace WebAPI_MVC_ASR.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null);

        Task<T?> GetAsync(Expression<Func<T, bool>>? filter = null);

    }
}
