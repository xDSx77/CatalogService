using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.DataAccess.Dbo
{
    public class CatalogTypes : IObjectWithId
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
