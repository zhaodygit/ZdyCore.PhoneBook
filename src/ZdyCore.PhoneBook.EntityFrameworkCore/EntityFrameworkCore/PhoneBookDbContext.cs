using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ZdyCore.PhoneBook.Authorization.Roles;
using ZdyCore.PhoneBook.Authorization.Users;
using ZdyCore.PhoneBook.MultiTenancy;

namespace ZdyCore.PhoneBook.EntityFrameworkCore
{
    public class PhoneBookDbContext : AbpZeroDbContext<Tenant, Role, User, PhoneBookDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PhoneBookDbContext(DbContextOptions<PhoneBookDbContext> options)
            : base(options)
        {
        }
    }
}
