using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Light.Abp.DicManagement.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See LightMigrationsDbContext for migrations.
     */
    [ConnectionStringName(AbpDicManagementDbProperties.ConnectionStringName)]
    public class AbpDicManagementDbContext : AbpDbContext<AbpDicManagementDbContext>, IAbpDicManagementDbContext
    {
        public AbpDicManagementDbContext(DbContextOptions<AbpDicManagementDbContext> options)
            : base(options)
        { }

        public DbSet<Dic> Dics { get; set; }

        public DbSet<ComplexDic> ComplexDics { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureDicManagement();
        }
    }
}
