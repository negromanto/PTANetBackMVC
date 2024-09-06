using System.Linq.Expressions;
using WebAPI_MVC_ASR.Datos;
using WebAPI_MVC_ASR.Models;
using WebAPI_MVC_ASR.Repository.IRepository;

namespace WebAPI_MVC_ASR.Repository
{
    public class FeedRepository : Repository<Feed>, IFeedRepository
    {
        private readonly ApplicationDbContext _context;
        public FeedRepository(ApplicationDbContext dbContext) :base(dbContext)
        {
            _context = dbContext;                         
        }

    }
}
