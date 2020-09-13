using CatalogService.DataAccess.Dbo;
using CatalogService.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.DataAccess.Repositories
{
    public class CatalogTypesRepository : ICatalogTypesRepository
    {
        public Task<bool> Delete(int idEntity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CatalogTypes>> Get(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<CatalogTypes> Insert(CatalogTypes entity)
        {
            throw new NotImplementedException();
        }

        public Task<CatalogTypes> Update(CatalogTypes entity)
        {
            throw new NotImplementedException();
        }
    }
}
