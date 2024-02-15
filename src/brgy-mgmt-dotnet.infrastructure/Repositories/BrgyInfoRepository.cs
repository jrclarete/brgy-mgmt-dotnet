using brgy_mgmt_dotnet.application.Contracts.Persistence;
using brgy_mgmt_dotnet.domain.Models;
using brgy_mgmt_dotnet.infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.infrastructure.Repositories
{
    public class BrgyInfoRepository : IBrgyInfoRepository
    {
        private readonly AppDbContext _appDbContext;

        public BrgyInfoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<BrgyInfo?> Get(int id)
        {
            return await _appDbContext.BrgyInfo.FirstOrDefaultAsync(x => !x.IsDeleted && x.Id == id);
        }

        public async Task<BrgyInfo?> Get()
        {
            return await _appDbContext.BrgyInfo.FirstOrDefaultAsync(x => !x.IsDeleted);
        }

        public async Task Update(BrgyInfo brgyInfo)
        {
            _appDbContext.Entry(brgyInfo).State = EntityState.Modified;
            await _appDbContext.SaveChangesAsync();
        }
    }
}
