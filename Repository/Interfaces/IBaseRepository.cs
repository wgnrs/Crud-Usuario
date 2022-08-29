namespace user.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetById(Guid id);
        Task<List<TEntity>> GetAll();
        bool Save(TEntity obj);
        bool Update(TEntity obj);
        bool Delete(TEntity obj);
    }
}