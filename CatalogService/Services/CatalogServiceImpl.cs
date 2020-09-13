using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogService.Models;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace CatalogService
{
    public class CatalogServiceImpl : CatalogService.CatalogServiceBase
    {
        private readonly ILogger<CatalogServiceImpl> _logger;
        public CatalogServiceImpl(ILogger<CatalogServiceImpl> logger)
        {
            _logger = logger;
        }

        public override Task<CatalogItems> CreateCatalogItem(CatalogItems request, ServerCallContext context)
        {
            return base.CreateCatalogItem(request, context);
        }

        public override Task<CatalogItems> GetItemById(Id request, ServerCallContext context)
        {
            return base.GetItemById(request, context);
        }

        public override Task<Ok> RemoveCatalogItem(CatalogItems request, ServerCallContext context)
        {
            return base.RemoveCatalogItem(request, context);
        }

        public override Task<Ok> UpdateCatalogItem(CatalogItems request, ServerCallContext context)
        {
            return base.UpdateCatalogItem(request, context);
        }
    }
}
