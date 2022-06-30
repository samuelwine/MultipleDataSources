using API_DBTryout.Data;
using Microsoft.EntityFrameworkCore;

namespace API_DBTryout
{
    public class ERAllData : IAllData
    {
        private readonly ERDbContext _context;
        private readonly MyClient _myClient;


        public ERAllData(ERDbContext context, MyClient myClient)
        {
            _context = context;
            _myClient = myClient;
        }

        public async Task<List<Shop>> Shops()
        {
            return await _context.Shops.ToListAsync();
        }

        public async Task<List<Shul>> Shuls()
        {
            return await _myClient.GetShuls("https://run.mocky.io/v3/767f5b9b-b065-4d9f-ba6e-64bf7182f1d1");
        }
    }


}
