using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Light.Abp.DicManagement
{
    public class CreateComplexDicDto
    {

        [Required]
        public string Category { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        /// <value>The code.</value>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        /// <value>The name.</value>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 父级代码
        /// </summary>
        /// <value>The parent code.</value>
        public string Parent { get; set; }

        public Dictionary<string, string> I18n { get; set; }
    }
}