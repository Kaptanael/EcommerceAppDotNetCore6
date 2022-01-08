using Ecommerce.DataAccess.Repositories;

namespace Ecommerce.DataAccess.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        IUserRepository Users { get; }
        IProductCategoryRepository ProductCategories { get; }
        int Complete();
        Task<int> CompleteAsync(CancellationToken cancellationToken = default);
    }
}
