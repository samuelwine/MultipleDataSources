﻿using API_DBTryout.Data;

namespace API_DBTryout
{
    public class LGShopRepository : IRepository<Shop>
    {
        private readonly LGDbContext _dbContext;

        public LGShopRepository(LGDbContext dbContext)
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
