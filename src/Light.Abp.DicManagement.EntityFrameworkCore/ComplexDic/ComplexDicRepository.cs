using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Light.Abp.DicManagement.EntityFrameworkCore
{
    public class ComplexDicRepository : EfCoreRepository<AbpDicManagementDbContext, ComplexDic, int>, IComplexDicRepository
    {
        public ComplexDicRepository(IDbContextProvider<AbpDicManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<List<string>> GetCategoriesAsync()
        {
            return await (await GetQueryableAsync()).Select(x => x.Category).Distinct().ToListAsync();
        }

        public async Task<List<ComplexDic>> GetListByCategoryAsync(string category)
        {
            return await (await GetQueryableAsync()).Where(x => x.Category == category).ToListAsync();

        }
    }
}