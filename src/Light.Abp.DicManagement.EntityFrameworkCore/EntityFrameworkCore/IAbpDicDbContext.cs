using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Light.Abp.DicManagement.EntityFrameworkCore
{
    [ConnectionStringName(AbpDicManagementDbProperties.ConnectionStringName)]
    public interface IAbpDicManagementDbContext : IEfCoreDbContext
    {
        DbSet<Dic> Dics { get; set; }

        DbSet<ComplexDic> ComplexDics { get; set; }
    }
}