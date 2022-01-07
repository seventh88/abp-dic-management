using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace Light.Abp.DicManagement
{
    public class Dic : AuditedEntity<int>
    {
        public Dic()
        {
        }

        public Dic(string category, string name, string code, int sort, Dictionary<string, string> i18n)
        {
            Category = category;
            Name = name;
            Code = code;
            Sort = sort;
            this.I18n = i18n;
        }
        public Dic(string category, string name, int sort, Dictionary<string, string> i18n) : this(category, name, name, sort, i18n)
        {
        }
        public Dic(string category, string name, int sort) : this(category, name, name, sort, new Dictionary<string, string>())
        {
        }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        public int Sort { get; set; }

        [Column(TypeName = "jsonb")]
        public Dictionary<string, string> I18n { get; set; }

    }
}
