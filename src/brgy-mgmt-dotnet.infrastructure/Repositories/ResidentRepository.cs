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
    public class ResidentRepository : GenericRepository<Resident>, IResidentRepository
    {
        private readonly AppDbContext _appDbContext;

        public ResidentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await Get(id);
            return entity != null;
        }

        public async Task<Resident?> Get(int id)
        {
            return await _appDbContext.Residents.FirstOrDefaultAsync(x => !x.IsDeleted && x.Id == id);
        }

        public async Task<IEnumerable<Resident?>> GetAll()
        {
            return await _appDbContext.Residents.Where(x => !x.IsDeleted).ToListAsync();
        }
    }
}
