using Ecommerce.DataAccess.Common;
using Ecommerce.Domain;

namespace Ecommerce.DataAccess.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {        
        public UserRepository(DataContext context) : base(context)
        {            
        }           
        
    }
}
