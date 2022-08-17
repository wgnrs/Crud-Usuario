namespace user.Repository
{
    public interface IBaseRepository<TEntity>
    {
        Task<TEntity> GetById(int id);
        Task<List<TEntity>> GetAll(int id);
        bool Save(TEntity obj);
        bool Update(TEntity obj);
        bool Delete(TEntity obj);
    }
}