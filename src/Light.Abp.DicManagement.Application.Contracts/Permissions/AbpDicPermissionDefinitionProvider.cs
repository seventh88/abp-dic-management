using Light.Abp.DicManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Light.Abp.DicManagement.Permissions
{
    public class AbpDicManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpDicManagementPermissions.GroupName, L("DicManagement"));

            #region Dic相关
            var dic = myGroup.AddPermission(AbpDicManagementPermissions.Dic.Default, L("Dic:View"));
            dic.AddChild(AbpDicManagementPermissions.Dic.Create, L("Permission:Create"));
            dic.AddChild(AbpDicManagementPermissions.Dic.Update, L("Permission:Update"));
            dic.AddChild(AbpDicManagementPermissions.Dic.Delete, L("Permission:Delete"));
            dic.AddChild(AbpDicManagementPermissions.Dic.Read, L("Permission:Read"));

         
            var complexDic = myGroup.AddPermission(AbpDicManagementPermissions.ComplexDic.Default, L("ComplexDic:View"));
            complexDic.AddChild(AbpDicManagementPermissions.ComplexDic.Create, L("Permission:Create"));
            complexDic.AddChild(AbpDicManagementPermissions.ComplexDic.Update, L("Permission:Update"));
            complexDic.AddChild(AbpDicManagementPermissions.ComplexDic.Delete, L("Permission:Delete"));
            complexDic.AddChild(AbpDicManagementPermissions.ComplexDic.Read, L("Permission:Read"));

            #endregion
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DicManagementResource>(name);
        }
    }
}
