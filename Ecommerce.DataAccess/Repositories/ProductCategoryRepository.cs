using Ecommerce.DataAccess.Common;
using Ecommerce.Domain;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.DataAccess.Repositories
{
    public class ProductCategoryRepository : Repository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(DataContext context) : base(context)
        {

        }
       
        public DataContext DataContext
        {
            get { return Context as DataContext; }
        }

        public async Task<IEnumerable<ProductCategory>> GetProductCategories(int pageIndex, int pageSize = 10)
        {           
            return await DataContext.ProductCategories.AsNoTracking().Skip(pageIndex).Take(pageSize).ToListAsync();
        }
    }
}
