using System;
using System.Collections.Generic;

namespace CatalogService.Models
{
    public partial class CatalogBrands
    {
        public CatalogBrands()
        {
            CatalogItems = new HashSet<CatalogItems>();
        }

        public int Id { get; set; }
        public string Brand { get; set; }

        public virtual ICollection<CatalogItems> CatalogItems { get; set; }
    }
}
