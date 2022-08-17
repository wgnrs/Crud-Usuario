using user.Model;

namespace user.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
           Task<User> GetByName(string name);
    }
}