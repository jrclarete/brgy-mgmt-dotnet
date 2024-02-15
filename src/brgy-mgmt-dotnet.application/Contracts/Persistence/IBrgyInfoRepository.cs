using brgy_mgmt_dotnet.domain.Models;

namespace brgy_mgmt_dotnet.application.Contracts.Persistence
{
    public interface IBrgyInfoRepository
    {
        Task<BrgyInfo?> Get();
        Task<BrgyInfo?> Get(int Id);
        Task Update(BrgyInfo brgyInfo);
    }
}
