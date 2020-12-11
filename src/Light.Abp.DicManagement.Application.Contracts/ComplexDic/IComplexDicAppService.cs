using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Light.Abp.DicManagement
{
    public interface IComplexDicAppService : ICrudAppService<ComplexDicDto, int, QueryComplexDicDto, CreateComplexDicDto, UpdateComplexDicDto>
    {
        Task<List<ComplexDicItem>> GetTreeAsync();

        Task<IEnumerable<string>> GetCategoryAsync();
    }
}
