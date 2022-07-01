namespace API_DBTryout
{
    public interface IRepository<T>
    {
        List<T> ListAll();
        int Add(T entity);
    }
}
