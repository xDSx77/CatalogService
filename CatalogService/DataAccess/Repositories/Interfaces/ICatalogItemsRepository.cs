﻿using CatalogService.DataAccess.Dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.DataAccess.Repositories.Interfaces
{
    public interface ICatalogItemsRepository : IRepository<Models.CatalogItems, Dbo.CatalogItems>
    {
        public Task<CatalogItems> GetByName(string name);
    }
}
