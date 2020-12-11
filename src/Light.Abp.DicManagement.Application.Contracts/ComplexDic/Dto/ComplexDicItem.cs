using System.Collections.Generic;

namespace Light.Abp.DicManagement
{
    public class ComplexDicItem
    {
        public int Id { get; set; }

        public string Category { get; set; }

        public string Parent { get; set; }
    
        public string Code { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the children.
        /// </summary>
        /// <value>The children.</value>
        public List<ComplexDicItem> Children { get; set; } = new List<ComplexDicItem>();

    }
}
