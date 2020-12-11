using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Light.Abp.DicManagement.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpDicManagementDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
        )]
    public class AbpDicManagementEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpDicManagementDbContext>();
        }
    }
}
