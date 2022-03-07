using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Quadrate.Authorization.Roles;
using Quadrate.Authorization.Users;
using Quadrate.MultiTenancy;

namespace Quadrate.EntityFrameworkCore
{
    public class QuadrateDbContext : AbpZeroDbContext<Tenant, Role, User, QuadrateDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public QuadrateDbContext(DbContextOptions<QuadrateDbContext> options)
            : base(options)
        {
        }
    }
}
