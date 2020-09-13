using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.DataAccess
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            AddTwoWayMapping<Dbo.CatalogBrands, Models.CatalogBrands>();
            AddTwoWayMapping<Dbo.CatalogItems, Models.CatalogItems>();
            AddTwoWayMapping<Dbo.CatalogTypes, Models.CatalogTypes>();
        }

        public void AddTwoWayMapping<T1, T2>()
        {
            CreateMap<T1, T2>();
            CreateMap<T2, T1>();
        }
    }
}
