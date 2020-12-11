using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Light.Abp.DicManagement
{
    public interface IDicAppService : ICrudAppService<DicDto, int, QueryDicDto, CreateDicDto, UpdateDicDto>
    {
        Task<IEnumerable<string>> GetCategoriesAsync();

        Task<List<DicItem>> GetDicByCategoryAsync(string category);
        Task<List<CategoryItem>> GetAllDicAsync();
    }
}