namespace API_DBTryout;

public interface IAllData
{
    Task<List<Shop>> Shops();
    Task<List<Shul>> Shuls();
}