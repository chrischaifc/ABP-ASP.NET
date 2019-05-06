using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MYABP.Authorization.Roles;
using MYABP.Authorization.Users;
using MYABP.MultiTenancy;
using MYABP.CMSService;

namespace MYABP.EntityFrameworkCore
{
    public class MYABPDbContext : AbpZeroDbContext<Tenant, Role, User, MYABPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
            public DbSet<Content> Contents { get; set; }

        public MYABPDbContext(DbContextOptions<MYABPDbContext> options)
            : base(options)
        {
        }
    }
}
