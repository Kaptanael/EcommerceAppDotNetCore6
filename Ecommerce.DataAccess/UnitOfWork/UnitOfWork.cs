using Ecommerce.DataAccess.Repositories;

namespace Ecommerce.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            ProductCategories = new ProductCategoryRepository(_context);
        }
        
        public IUserRepository Users { get; private set; }
        public IProductCategoryRepository ProductCategories {  get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CompleteAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
