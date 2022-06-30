namespace API_DBTryout;

public class LGAllData : IAllData
{
    private readonly MyClient _myClient;


    public LGAllData(MyClient myClient)
    {
        _myClient = myClient;
    }

    public async Task<List<Shop>> Shops()
    {
        return await _myClient.GetShops("https://run.mocky.io/v3/cf96f59b-03f4-43dd-9787-c286faaaafe0");
    }

    public async Task<List<Shul>> Shuls()
    {
        return await _myClient.GetShuls("https://run.mocky.io/v3/767f5b9b-b065-4d9f-ba6e-64bf7182f1d1");
    }
}