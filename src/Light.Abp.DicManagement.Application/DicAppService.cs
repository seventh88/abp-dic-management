using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Light.Abp.DicManagement.Localization;
using Light.Abp.DicManagement.Permissions;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Services;
using Volo.Abp.Validation;

namespace Light.Abp.DicManagement
{
    [Authorize(AbpDicManagementPermissions.Dic.Default)]
    public class DicAppService : CrudAppService<Dic, DicDto, int, QueryDicDto,
        CreateDicDto, UpdateDicDto>, IDicAppService
    {
        private readonly IDicRepository _repository;

        public DicAppService(IDicRepository repository) : base(repository)
        {
            LocalizationResource = typeof(DicManagementResource);
            ObjectMapperContext = typeof(AbpDicManagementApplicationModule);
            this._repository = repository;
        }

        protected override string GetPolicyName => AbpDicManagementPermissions.Dic.Read;

        protected override string GetListPolicyName => AbpDicManagementPermissions.Dic.Read;

        protected override string CreatePolicyName => AbpDicManagementPermissions.Dic.Create;

        protected override string UpdatePolicyName => AbpDicManagementPermissions.Dic.Update;

        protected override string DeletePolicyName => AbpDicManagementPermissions.Dic.Delete;

        protected override IQueryable<Dic> CreateFilteredQuery(QueryDicDto input)
        {
            IQueryable<Dic> queryable = Repository.Where(x => x.Category == input.Category);
            if (!string.IsNullOrWhiteSpace(input.Filter))
            {
                queryable = queryable.Where(x => x.Name.Contains(input.Filter) || x.Code.Contains(input.Filter));
            }
            return queryable;
        }

        [AllowAnonymous]
        public virtual async Task<IEnumerable<string>> GetCategoriesAsync()
        {
            return await _repository.GetCategoriesAsync();
        }

        [AllowAnonymous]
        public virtual async Task<List<DicItem>> GetDicByCategoryAsync(string category)
        {
            var lang = CultureInfo.CurrentCulture.Name;
            var categories = await _repository.GetCategoriesAsync();
            if (!categories.Contains(category))
            {
                throw new AbpValidationException(L["UnknownDicCategory"]);
            }
            var entities = await _repository.GetListByCategoryAsync(category);
            return entities.Select(x => new DicItem
            {
                Code = x.Code,
                Name = (x.I18n == null || !x.I18n.ContainsKey(lang)) ? x.Name : x.I18n[lang],
                I18n = x.I18n
            }).ToList();
        }

        [AllowAnonymous]
        public virtual async Task<List<CategoryItem>> GetAllDicAsync()
        {
            var lang = CultureInfo.CurrentCulture.Name;

            var entities = await _repository.GetListAsync();
            return entities.GroupBy(x => x.Category).Select(x => new CategoryItem
            {
                Category = x.Key,
                Items = x.Select(y => new DicItem
                {
                    Code = y.Code,
                    Name = (y.I18n == null || !y.I18n.ContainsKey(lang)) ? y.Name : y.I18n[lang],
                    I18n = y.I18n
                }).ToList()
            }).ToList();
        }
    }
}
