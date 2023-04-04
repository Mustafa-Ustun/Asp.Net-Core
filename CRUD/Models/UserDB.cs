using Microsoft.EntityFrameworkCore;

namespace CRUD.Models
{
    public class UserDB:DbContext
    {

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Mustafa\\SQLEXPRESS;Database=UserDBContext;Trusted_Connection=True");
        }

    }
}
