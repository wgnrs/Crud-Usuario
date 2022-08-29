using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using user.Data;
using user.Model;

namespace user.Repository.Interfaces

{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : Identifier
    {
        protected UserDbContext context;
        public BaseRepository() : base()
        {
            this.context = new UserDbContext();
        }
        public BaseRepository(DbContextOptions<UserDbContext> options) : base ()
        {
            this.context = new UserDbContext(options);
        }

        public virtual async Task<List<T>> GetAll()
        {
            var list = await context.Set<T>().ToListAsync();
            return list;
        }

        public virtual async Task<T> GetById(Guid id)
        {
            var entity = await context.Set<T>().FirstOrDefaultAsync(x => x.IdGuid == id);
            return entity;
        }

        public virtual bool Save(T obj)
        {
            context.Set<T>().Add(obj);
            return true;
        }

        public virtual bool Update(T obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            return true;
        }

        public virtual bool Delete(T obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            return true;
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