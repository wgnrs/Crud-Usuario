using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

using user.Model;
using user.Repository.Interfaces;

namespace user.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {        
        private readonly IUserRepository _userRepository;
        public UserRepository(IUserRepository userRepository) : base ()
        {
            this._userRepository = userRepository;         
        }
       
        public Task<User> GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}