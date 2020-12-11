using Volo.Abp.Modularity;

namespace Light.Abp.DicManagement
{
    [DependsOn(
        typeof(AbpDicManagementDomainSharedModule)
    )]

    public class AbpDicManagementApplicationContractsModule : AbpModule
    {

    }
}
