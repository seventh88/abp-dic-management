using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Light.Abp.DicManagement.EntityFrameworkCore
{
    public class AbpDicManagementModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public AbpDicManagementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(tablePrefix, schema)
        {
        }
    }
}
