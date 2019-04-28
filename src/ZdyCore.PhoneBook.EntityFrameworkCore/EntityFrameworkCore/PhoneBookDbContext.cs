using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ZdyCore.PhoneBook.Authorization.Roles;
using ZdyCore.PhoneBook.Authorization.Users;
using ZdyCore.PhoneBook.MultiTenancy;
using ZdyCore.PhoneBook.PhoneBooks.Persons;
using ZdyCore.PhoneBook.PhoneBooks.PhoneNumbers;

namespace ZdyCore.PhoneBook.EntityFrameworkCore
{
    public class PhoneBookDbContext : AbpZeroDbContext<Tenant, Role, User, PhoneBookDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PhoneBookDbContext(DbContextOptions<PhoneBookDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person", "PB");
            modelBuilder.Entity<PhoneNumber>().ToTable("PhoneNumber", "PB");
            base.OnModelCreating(modelBuilder);
        }
    }
}
