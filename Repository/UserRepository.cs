using user.Model;
using user.Repository.Interfaces;

namespace user.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Task<User> GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}