namespace brgy_mgmt_dotnet.application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : class
    {
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
