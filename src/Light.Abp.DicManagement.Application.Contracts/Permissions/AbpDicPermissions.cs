namespace Light.Abp.DicManagement.Permissions
{
    public static class AbpDicManagementPermissions
    {
        public const string GroupName = "DicManagement";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public static class Dic
        {
            public const string Default = GroupName + ".Dics";
            public const string Create = Default + ".Create";
            public const string Update = Default + ".Update";
            public const string Delete = Default + ".Delete";
            public const string Read = Default + ".Read";
        }

        public class ComplexDic
        {
            public const string Default = GroupName + ".ComplexDics";
            public const string Create = Default + ".Create";
            public const string Update = Default + ".Update";
            public const string Delete = Default + ".Delete";
            public const string Read = Default + ".Read";
        }
    }
}