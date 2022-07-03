using API_DBTryout.Data;

namespace API_DBTryout
{
    public class LGShulRepository : IRepository<Shul>
    {
        private readonly LGDbContext _dbContext;

        public LGShulRepository(LGDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Shul> ListAll()
        {
            return _dbContext.Shuls.ToList();
        }

        public int Add(Shul entity)
        {
            return 0;
        }
    }
}
