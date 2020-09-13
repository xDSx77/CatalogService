using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.DataAccess.Dbo
{
    public class CatalogItems
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string PictureFilename { get; set; }
        public int? BrandId { get; set; }
        public int? TypeId { get; set; }
    }
}
