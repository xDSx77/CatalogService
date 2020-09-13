using System;
using System.Collections.Generic;

namespace CatalogService.Models
{
    public partial class CatalogTypes
    {
        public CatalogTypes()
        {
            CatalogItems = new HashSet<CatalogItems>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<CatalogItems> CatalogItems { get; set; }
    }
}
