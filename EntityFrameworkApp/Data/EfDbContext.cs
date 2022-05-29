using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkApp.Data
{
    public class EfDbContext : DbContext
    {
        public EfDbContext(DbContextOptions<EfDbContext> options) : base(options)
        {

            //Burda dbContext constructer ına  options yolladık.

        }


        //Burda oluşacak tüm classları tablolarını oluşturcak. 
        public DbSet<Class> Classes { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<School> Schools { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }



    }
}
