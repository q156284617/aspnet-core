using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using WebProject.Authorization.Roles;
using WebProject.Authorization.Users;
using WebProject.MultiTenancy;

namespace WebProject.EntityFrameworkCore
{
    public class WebProjectDbContext : AbpZeroDbContext<Tenant, Role, User, WebProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public WebProjectDbContext(DbContextOptions<WebProjectDbContext> options)
            : base(options)
        {
        }
    }
}
