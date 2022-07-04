using API_DBTryout.Data;

namespace API_DBTryout
{
    public class LGGenericRepository<T> : IRepository<T> where T : class
    {
        private readonly LGDbContext _dbContext;

        public LGGenericRepository()
        {

        }

        public LGGenericRepository(LGDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<T> ListAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public int Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            return _dbContext.SaveChanges();

        }
    }
}
