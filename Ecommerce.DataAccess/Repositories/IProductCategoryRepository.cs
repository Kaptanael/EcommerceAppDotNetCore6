using Ecommerce.DataAccess.Common;
using Ecommerce.Domain;

namespace Ecommerce.DataAccess.Repositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
        Task<IEnumerable<ProductCategory>> GetProductCategories(int pageIndex, int pageSize = 10);
    }
}
