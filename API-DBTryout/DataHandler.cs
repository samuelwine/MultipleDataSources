namespace API_DBTryout
{
    public class DataHandler
    {
        public IRepository<Shop> Shops { get; set; }

        public IRepository<Shul> Shuls { get; set; }

        public DataHandler(IRepository<Shop> shops, IRepository<Shul> shuls)
        {
            Shops = shops;
            Shuls = shuls;
        }
    }
}
