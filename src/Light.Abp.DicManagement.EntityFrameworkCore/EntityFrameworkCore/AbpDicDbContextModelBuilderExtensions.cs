using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using Light.Abp.DicManagement;
using Light.Abp.DicManagement.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

public static class AbpDicManagementDbContextModelBuilderExtensions
{
    public static void ConfigureDicManagement(
        [NotNull] this ModelBuilder builder,
        Action<AbpDicManagementModelBuilderConfigurationOptions> optionsAction = null)
    {
        Check.NotNull(builder, nameof(builder));

        var options = new AbpDicManagementModelBuilderConfigurationOptions(
            AbpDicManagementDbProperties.DbTablePrefix,
            AbpDicManagementDbProperties.DbSchema
        );

        optionsAction?.Invoke(options);

        builder.Entity<Dic>(b =>
        {
            b.ToTable(options.TablePrefix + "Dics", options.Schema);
            b.ConfigureAudited();
            b.ConfigureByConvention();
        });

        builder.Entity<ComplexDic>(b =>
        {
            b.ToTable(options.TablePrefix + "ComplexDics", options.Schema);
            b.ConfigureAudited();
            b.ConfigureByConvention();
        });
    }
   
}
