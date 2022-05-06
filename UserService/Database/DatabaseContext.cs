using Microsoft.EntityFrameworkCore;
using UserService.Database.Entities;

namespace UserService.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=MSI\SQLEXPRESS; initial catalog=UserMicroservice;
                persist security info=true;user id=sa;password=#compaq123");
        }
    }
}
