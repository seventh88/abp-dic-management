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

        public Dic(string category, string name, string code, Dictionary<string, string> i18n)
        {
            Category = category;
            Name = name;
            Code = code;
            this.I18n = i18n;
        }
        public Dic(string category, string name, Dictionary<string, string> i18n) : this(category, name, name, i18n)
        {
        }
        public Dic(string category, string name) : this(category, name, name, new Dictionary<string, string>())
        {
        }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        [Column(TypeName = "jsonb")]
        public Dictionary<string, string> I18n { get; set; }

    }
}
