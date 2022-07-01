namespace API_DBTryout
{
    public class ERShulRepository : IRepository<Shul>
    {
        private readonly MyClient _myClient;

        public ERShulRepository(MyClient myClient)
        {
            _myClient = myClient;
        }

        public List<Shul> ListAll()
        {
            return _myClient.GetShuls("https://run.mocky.io/v3/767f5b9b-b065-4d9f-ba6e-64bf7182f1d1").Result;
        }

        public int Add(Shul entity)
        {
            return 0;
        }
    }
}
