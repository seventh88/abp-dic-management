using Newtonsoft.Json;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Light.Abp.DicManagement
{
    public class DicDto : AuditedEntityDto<int>
    {
        public string Category { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        /// <value>The code.</value>
        public string Code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        public Dictionary<string, string> I18n { get; set; }

        public string I18nTxt => JsonConvert.SerializeObject(I18n);
    }
}