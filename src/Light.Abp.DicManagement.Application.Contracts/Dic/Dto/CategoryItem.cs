using System.Collections.Generic;

namespace Light.Abp.DicManagement
{
    public class CategoryItem
    {

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>The category.</value>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>The items.</value>
        public List<DicItem> Items { get; set; }
    }
}
