using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogService.DataAccess.Dbo;
using CatalogService.DataAccess.Repositories.Interfaces;
using CatalogService.Models;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace CatalogService
{
    public class CatalogServiceImpl : CatalogService.CatalogServiceBase
    {
        private readonly ILogger<CatalogServiceImpl> _logger;
        private readonly ICatalogItemsRepository _catalogItemsRepository;
        public CatalogServiceImpl(ICatalogItemsRepository catalogItemsRepository, ILogger<CatalogServiceImpl> logger)
        {
            _catalogItemsRepository = catalogItemsRepository;
            _logger = logger;
        }

        public override async Task<CatalogItemResponse> CreateCatalogItem(CatalogItemRequest request, ServerCallContext context)
        {
            DataAccess.Dbo.CatalogItems catalogItem = new DataAccess.Dbo.CatalogItems()
            {
                Description = request.Description,
                Name = request.Name,
                PictureFilename = request.PictureFilename,
                Price = (decimal)request.Price,
                BrandId = request.BrandId,
                TypeId = request.TypeId
            };
            DataAccess.Dbo.CatalogItems catalogItemResult = await _catalogItemsRepository.Insert(catalogItem);
            if (catalogItemResult != null)
            {
                return new CatalogItemResponse()
                {
                    Id = catalogItemResult.Id,
                    Description = catalogItemResult.Description,
                    PictureFilename = catalogItemResult.PictureFilename,
                    Price = (float)catalogItemResult.Price,
                    BrandId = catalogItemResult.BrandId.HasValue ? catalogItemResult.BrandId.Value : 0,
                    TypeId = catalogItemResult.TypeId.HasValue ? catalogItemResult.TypeId.Value : 0
                };
            }
            else
                return null;
        }

        public override async Task<CatalogItemResponse> GetItemById(Id request, ServerCallContext context)
        {
            IEnumerable<DataAccess.Dbo.CatalogItems> catalogItemsResult = await _catalogItemsRepository.Get(request.Id_);
            if (catalogItemsResult != null)
            {
                DataAccess.Dbo.CatalogItems catalogItemResult = catalogItemsResult.FirstOrDefault();
                return new CatalogItemResponse()
                {
                    Id = catalogItemResult.Id,
                    Description = catalogItemResult.Description,
                    PictureFilename = catalogItemResult.PictureFilename,
                    Price = (float)catalogItemResult.Price,
                    BrandId = catalogItemResult.BrandId.HasValue ? catalogItemResult.BrandId.Value : 0,
                    TypeId = catalogItemResult.TypeId.HasValue ? catalogItemResult.TypeId.Value : 0
                };
            }
            else
                return null;
        }

        public override async Task<Ok> RemoveCatalogItem(CatalogItemRequest request, ServerCallContext context)
        {
            DataAccess.Dbo.CatalogItems catalogItemResult = await _catalogItemsRepository.GetByName(request.Name);
            if (catalogItemResult != null)
                return new Ok() { Ok_ = await _catalogItemsRepository.Delete(catalogItemResult.Id) };
            else
                return new Ok() { Ok_ = false };
        }

        public override async Task<Ok> UpdateCatalogItem(CatalogItemResponse request, ServerCallContext context)
        {
            IEnumerable<DataAccess.Dbo.CatalogItems> catalogItemsResult = await _catalogItemsRepository.Get(request.Id);
            if (catalogItemsResult != null)
            {
                DataAccess.Dbo.CatalogItems catalogItemResult = catalogItemsResult.FirstOrDefault();
                catalogItemResult.Description = request.Description;
                catalogItemResult.Name = request.Name;
                catalogItemResult.PictureFilename = request.PictureFilename;
                catalogItemResult.Price = (decimal)request.Price;
                catalogItemResult.BrandId = request.BrandId;
                catalogItemResult.TypeId = request.TypeId;
                return new Ok() { Ok_ = await _catalogItemsRepository.Update(catalogItemResult) != null ? true : false };
            }
            else
                return new Ok() { Ok_ = false };
        }
    }
}
