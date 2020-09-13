using CatalogService.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.DataAccess.Repositories
{
    public class CatalogItemsRepository : ICatalogItemsRepository
    {
        public Task<bool> Delete(int idEntity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dbo.CatalogItems>> Get(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Dbo.CatalogItems> Insert(Dbo.CatalogItems entity)
        {
            throw new NotImplementedException();
        }

        public Task<Dbo.CatalogItems> Update(Dbo.CatalogItems entity)
        {
            throw new NotImplementedException();
        }
    }
}
