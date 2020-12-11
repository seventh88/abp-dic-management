using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Light.Abp.DicManagement
{
    public interface IDicRepository : IRepository<Dic, int>
    {
        Task<List<Dic>> GetListByCategoryAsync(string category, CancellationToken cancellationToken = default);
       
        Task<List<string>> GetCategoriesAsync();
    }
}