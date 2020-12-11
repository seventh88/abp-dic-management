using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.AutoMapper;

namespace Light.Abp.DicManagement
{
    [DependsOn(
        typeof(AbpDicManagementDomainModule),
        typeof(AbpAutoMapperModule),
        typeof(AbpDicManagementApplicationContractsModule)
        )]
    public class AbpDicManagementApplicationModule : AbpModule
    {

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<AbpDicManagementApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<AbpDicManagementApplicationModule>();
            });
        }
    }
}
