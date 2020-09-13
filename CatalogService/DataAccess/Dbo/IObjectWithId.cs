using System;

namespace CatalogService.DataAccess.Dbo
{
    public interface IObjectWithId
    {
        public int Id { get; set; }
    }
}
