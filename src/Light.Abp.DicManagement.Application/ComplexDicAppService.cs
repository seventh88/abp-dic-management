using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Light.Abp.DicManagement.Localization;
using Light.Abp.DicManagement.Permissions;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Services;

namespace Light.Abp.DicManagement
{
    [Authorize(AbpDicManagementPermissions.ComplexDic.Default)]
    public class ComplexDicAppService : CrudAppService<ComplexDic, ComplexDicDto, int, QueryComplexDicDto,
        CreateComplexDicDto, UpdateComplexDicDto>, IComplexDicAppService
    {
        private readonly IComplexDicRepository _repository;

        public ComplexDicAppService(IComplexDicRepository repository) : base(repository)
        {
            this._repository = repository;
            LocalizationResource = typeof(DicManagementResource);
            ObjectMapperContext = typeof(AbpDicManagementApplicationModule);
        }

        protected override string GetPolicyName => AbpDicManagementPermissions.ComplexDic.Read;

        protected override string GetListPolicyName => AbpDicManagementPermissions.ComplexDic.Read;

        protected override string CreatePolicyName => AbpDicManagementPermissions.ComplexDic.Create;

        protected override string UpdatePolicyName => AbpDicManagementPermissions.ComplexDic.Update;

        protected override string DeletePolicyName => AbpDicManagementPermissions.ComplexDic.Delete;

        protected override async Task<IQueryable<ComplexDic>> CreateFilteredQueryAsync(QueryComplexDicDto input)
        {
            IQueryable<ComplexDic> queryable = (await Repository.GetQueryableAsync()).Where(x => x.Category == input.Category);
            if (!string.IsNullOrWhiteSpace(input.Filter))
            {
                queryable = queryable.Where(x => x.Name.Contains(input.Filter) || x.Code.Contains(input.Filter));
            }
            return queryable;
        }

        [AllowAnonymous]
        public async Task<IEnumerable<string>> GetCategoryAsync()
        {
            return await _repository.GetCategoriesAsync();
        }

        [AllowAnonymous]
        public async Task<List<ComplexDicItem>> GetTreeAsync()
        {
            var categories = await _repository.GetCategoriesAsync();
            var data = await _repository.GetListAsync();
            var topData = data.Where(x => string.IsNullOrEmpty(x.Parent));
            var treeData = topData.Select(x => CreateItem(data, x)).ToList();
            return categories.Select(top => new ComplexDicItem
            {
                Category = top,
                Name = top,
                Children = treeData.Where(x => x.Category == top).ToList()
            }).ToList();
        }

        private ComplexDicItem CreateItem(List<ComplexDic> allData, ComplexDic parent)
        {
            var item = new ComplexDicItem
            {
                Id = parent.Id,
                Category = parent.Category,
                Parent = parent.Parent,
                Code = parent.Code,
                Name = parent.Name,
            };
            var children = allData.Where(x => x.Parent == parent.Code);
            foreach (var child in children)
            {
                item.Children.Add(CreateItem(allData, child));
            }
            return item;
        }

    }
}
