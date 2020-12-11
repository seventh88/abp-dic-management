using Volo.Abp.Domain;
using Volo.Abp.Modularity;


namespace Light.Abp.DicManagement
{
    [DependsOn(
        typeof(AbpDicManagementDomainSharedModule),
        typeof(AbpDddDomainModule))]

    public class AbpDicManagementDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}
