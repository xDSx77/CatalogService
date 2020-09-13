using AutoMapper;
using CatalogService.DataAccess.Dbo;
using CatalogService.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.DataAccess.Repositories
{
    public class CatalogBrandsRepository : Repository<Models.CatalogBrands, CatalogBrands>, ICatalogBrandsRepository
    {
        public CatalogBrandsRepository(Models.catalogContext context, ILogger<CatalogBrandsRepository> logger, IMapper mapper) : base(context.CatalogBrands, context, logger, mapper)
        {
        }


    }
}
