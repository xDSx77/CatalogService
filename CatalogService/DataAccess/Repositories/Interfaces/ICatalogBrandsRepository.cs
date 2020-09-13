using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.DataAccess.Repositories.Interfaces
{
    public interface ICatalogBrandsRepository : IRepository<Models.CatalogBrands, Dbo.CatalogBrands>
    {
    }
}
