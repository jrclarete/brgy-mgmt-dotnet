using brgy_mgmt_dotnet.domain.Models;

namespace brgy_mgmt_dotnet.application.Contracts.Persistence
{
    public interface IResidentRepository : IGenericRepository<Resident>
    {
        Task<IEnumerable<Resident?>> GetAll();
        Task<Resident?> Get(int Id);
        Task<bool> Exists(int id);
    }
}
