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
    public class CatalogItemsRepository : Repository<Models.CatalogItems, CatalogItems>, ICatalogItemsRepository
    {
        public CatalogItemsRepository(Models.catalogContext context, ILogger<CatalogItemsRepository> logger, IMapper mapper) : base(context.CatalogItems, context, logger, mapper)
        {
        }

        public async Task<CatalogItems> GetByName(string name)
        {
            try
            {
                var catalogItem = await (from catalogItems in _context.CatalogItems.AsNoTracking()
                                   where catalogItems.Name == name
                                   select catalogItems).FirstOrDefaultAsync();
                return _mapper.Map<CatalogItems>(catalogItem);
            }
            catch (Exception ex)
            {
                _logger.LogError("Cannot get this entry", ex);
                return null;
            }
        }
    }
}
