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
    public class CatalogTypesRepository : Repository<Models.CatalogTypes, CatalogTypes>, ICatalogTypesRepository
    {
        public CatalogTypesRepository(Models.catalogContext context, ILogger<CatalogTypesRepository> logger, IMapper mapper) : base(context.CatalogTypes, context, logger, mapper)
        {
        }


    }
}
