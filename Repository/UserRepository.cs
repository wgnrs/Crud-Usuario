using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using user.Data;
using user.Model;
using user.Repository.Interfaces;

namespace user.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {        
        private readonly IUserRepository _context;
        public UserRepository(UserDbContext context) : base ()
        {
            this._context = context;         
        }
       
        public Task<User> GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}