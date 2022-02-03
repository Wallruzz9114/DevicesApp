using AutoMapper;
using Data.Contexts;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Abstract;

namespace Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected AppDbContext _dbContext;
        protected DbSet<TEntity> _set;
        protected IMapper _mapper;

        protected IQueryable<TEntity> BaseQuery => _set;

        public Repository(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _set = dbContext.Set<TEntity>();
            _mapper = mapper;
        }

        public void Add(TEntity entity) => _set.Add(entity);

        public virtual async Task<TEntity> GetByIdAsync(int id)
            => await BaseQuery.SingleOrDefaultAsync(e => e.Id == id);

        public async Task<IEnumerable<TEntity>> GetAll()
            => await BaseQuery.ToListAsync();
    }
}