using Microsoft.EntityFrameworkCore;

namespace Book_Library_NETCore_st_proj.Models
{
    public class BookLibContext : DbContext
    {
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<BooksShared> BooksShared { get; set; }

        public BookLibContext(DbContextOptions<BookLibContext> options) : base(options)
        {
       
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string adminRoleName = "admin";
            string userRoleName = "user";

            string adminEmail = "admin@mail.ru";
            string adminPassword = "123456";

            // добавляем роли
            Role adminRole = new Role { ID = 1, Name = adminRoleName };
            Role userRole = new Role { ID = 2, Name = userRoleName };
            User adminUser = new User { ID = 1, Email = adminEmail, Password = adminPassword, Role = UserStatus.Admin };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
            modelBuilder.Entity<User>().HasData(new User[] { adminUser });
            base.OnModelCreating(modelBuilder);
        }
    }
    
}
