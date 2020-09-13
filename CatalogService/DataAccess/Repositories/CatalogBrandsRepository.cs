using CatalogService.DataAccess.Dbo;
using CatalogService.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.DataAccess.Repositories
{
    public class CatalogBrandsRepository : ICatalogBrandsRepository
    {
        public Task<bool> Delete(int idEntity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CatalogBrands>> Get(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<CatalogBrands> Insert(CatalogBrands entity)
        {
            throw new NotImplementedException();
        }

        public Task<CatalogBrands> Update(CatalogBrands entity)
        {
            throw new NotImplementedException();
        }
    }
}
