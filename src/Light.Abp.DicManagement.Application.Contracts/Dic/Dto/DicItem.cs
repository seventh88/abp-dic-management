using System.Collections.Generic;

namespace Light.Abp.DicManagement
{
    public class DicItem
    {
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

        public int Sort { get; set; }

        /// <summary>
        /// I18n
        /// </summary>
        /// <value>The i18n.</value>
        public Dictionary<string, string> I18n { get; set; }
    }
}
