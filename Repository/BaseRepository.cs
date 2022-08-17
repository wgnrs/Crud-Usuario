using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace user.Repository.Interfaces

{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public ApplicationDbContext context;

        public BaseRepository(ApplicationDbContext context)
        {
            this.context = context;
        }       

        public async Task<List<T>> GetAll(int id)
        {
            var list = await QueryAll().ToListAsync();
            return list;
        }

        public async Task<T> GetById(int id)
        {
            var entity = await QueryAll().FirstOrDefaultAsync();
            return entity;
        }

        public bool Save(T obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(T obj)
        {
            throw new NotImplementedException();
        }

         public bool Delete(T obj)
        {
            throw new NotImplementedException();
        }

        private IQueryable<T> QueryAll()
        {
            var query = context.Set<T>();
            return query;
        }

        private IQueryable<T> QueryById()
        {
            var query = context.Set<T>();
            return query;
        }
    }
}