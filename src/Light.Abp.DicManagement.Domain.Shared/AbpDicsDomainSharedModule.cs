using Light.Abp.DicManagement.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.Validation.Localization;
using Volo.Abp.Validation;

namespace Light.Abp.DicManagement
{
    [DependsOn(typeof(AbpValidationModule))]
    public class AbpDicManagementDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<AbpDicManagementDomainSharedModule>("Light.Abp.DicManagement.");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<DicManagementResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/Resource");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("DicManagement", typeof(DicManagementResource));
            });
        }
    }
}
