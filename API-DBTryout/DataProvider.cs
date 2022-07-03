namespace API_DBTryout
{
    public class DataProvider
    {
        public IRepository<Shop> Shops { get; set; }

        public IRepository<Shul> Shuls { get; set; }

        public DataProvider(IRepository<Shop> shops, IRepository<Shul> shuls)
        {
            Shops = shops;
            Shuls = shuls;
        }
    }
}
