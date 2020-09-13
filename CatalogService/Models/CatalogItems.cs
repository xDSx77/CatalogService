using System;
using System.Collections.Generic;

namespace CatalogService.Models
{
    public partial class CatalogItems
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string PictureFilename { get; set; }
        public decimal Price { get; set; }
        public int? BrandId { get; set; }
        public int? TypeId { get; set; }

        public virtual CatalogBrands Brand { get; set; }
        public virtual CatalogTypes Type { get; set; }
    }
}
