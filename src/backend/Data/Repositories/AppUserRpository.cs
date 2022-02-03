using AutoMapper;
using Data.Contexts;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace Data.Repositories
{
    public class AppUserRpository : Repository<AppUser>, IAppUserRepository
    {
        protected new IQueryable<AppUser> BaseQuery => _dbContext.AppUsers;

        public AppUserRpository(AppDbContext dbContext, IMapper mapper) : base(dbContext, mapper) { }

        public async Task<AppUser> GetByEmailAsync(string email, CancellationToken cancellationToken)
            => await BaseQuery.FirstOrDefaultAsync(x => x.Email == email.ToLower(), cancellationToken);
    }
}