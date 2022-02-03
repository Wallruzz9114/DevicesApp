using Models.Abstract;

namespace Data.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetByIdAsync(int id);
        void Add(TEntity entity);
        Task<IEnumerable<TEntity>> GetAll();
    }
}