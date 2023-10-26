using eCommerce.API.Database;
using eCommerce.API.Repositories.Interfaces;
using eCommerce.Models;

namespace eCommerce.API.Repositories.DB
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(eCommerceContext context) : base(context) { }
    }
}
