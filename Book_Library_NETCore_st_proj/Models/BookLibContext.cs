using Microsoft.EntityFrameworkCore;

namespace Book_Library_NETCore_st_proj.Models
{
    public class BookLibContext : DbContext
    {
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<User> User { get; set; }

        public BookLibContext(DbContextOptions<BookLibContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
