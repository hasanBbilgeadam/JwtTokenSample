using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Contexts
{
    public class AppDbContext:DbContext
    {

        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UserRole>().HasOne(x=>x.AppRole).WithMany(x=>x.userRoles).HasForeignKey(x=>x.RoleId);
            modelBuilder.Entity<UserRole>().HasOne(x=>x.AppUser).WithMany(x=>x.userRoles).HasForeignKey(x=>x.UserId);


            modelBuilder.Entity<UserRole>().HasKey(x => new
            {
                x.UserId,
                x.RoleId

            });

        }
    }



    public class AppUser
    {
        public int Id { get; set; }
        public string  Email { get; set; }
        public string  Password { get; set; }
        public List<UserRole> userRoles { get; set; } = new();
    }

    public class AppRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; }

        public List<UserRole> userRoles { get; set; } = new();
    }

    //cross table
    public class UserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public AppUser AppUser { get; set; }
        public AppRole AppRole { get; set; }

    }


}
