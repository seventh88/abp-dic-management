using Volo.Abp.Data;

namespace Light.Abp.DicManagement.EntityFrameworkCore
{
    public static class AbpDicManagementDbProperties
    {
        public static string DbTablePrefix { get; set; } = AbpCommonDbProperties.DbTablePrefix;

        public static string DbSchema { get; set; } = AbpCommonDbProperties.DbSchema;

        public const string ConnectionStringName = "AbpDicManagement";
    }
}