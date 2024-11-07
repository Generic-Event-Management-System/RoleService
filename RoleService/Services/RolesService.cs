using RoleService.Persistence;
using RoleService.Services.Contracts;

namespace RoleService.Services
{
    public class RolesService : IRolesService
    {
        private readonly RoleDbContext _dbContext;

        public RolesService(RoleDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
