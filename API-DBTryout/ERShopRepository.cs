using API_DBTryout.Data;

namespace API_DBTryout
{
    public class ERShopRepository : IRepository<Shop>
    {
        private readonly ERDbContext _dbContext;

        public ERShopRepository(ERDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Shop> ListAll()
        {
            return _dbContext.Shops.ToList();
        }

        public int Add(Shop entity)
        {
            _dbContext.Shops.Add(entity);
            return _dbContext.SaveChanges();

        }
    }
}
