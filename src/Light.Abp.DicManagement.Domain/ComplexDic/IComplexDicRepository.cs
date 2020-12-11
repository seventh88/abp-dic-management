using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Light.Abp.DicManagement
{
    public interface IComplexDicRepository : IRepository<ComplexDic, int>
    {
        Task<List<string>> GetCategoriesAsync();

        Task<List<ComplexDic>> GetListByCategoryAsync(string category);
    }
}